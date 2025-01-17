using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Runtime
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class MonoPInvokeCallbackAttribute : Attribute
    {
        public MonoPInvokeCallbackAttribute() { }
    }

    internal delegate void VoidResultCallback(IntPtr taskPtr);
    internal delegate void ResultCallback<T>(IntPtr taskPtr, T result);

    /// <summary>
    /// Represents an asynchronous operation for single-threaded environments.
    /// </summary>
    [AsyncMethodBuilder(typeof(WebTaskBuilder))]
    public class WebTask
    {
        /// <summary>
        /// Indicates whether the task has completed.
        /// </summary>
        public bool IsCompleted { get; private set; }

        /// <summary>
        /// Indicates whether the task completed due to an unhandled exception.
        /// </summary>
        public bool IsFaulted { get => Exception != null; }

        /// <summary>
        /// The exception that caused the task to end prematurely. If the task completed successfully or has not yet thrown any exceptions, this will be null.
        /// </summary>
        public Exception Exception { get; private set; }

        private WebTaskAwaiter Awaiter { get; }
        private event Action Finished;

        /// <summary>
        /// Gets an awaiter used to await this task. Required member to make the task awaitable.
        /// This API supports the product infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <returns>An awaiter instance.</returns>
        public WebTaskAwaiter GetAwaiter() => Awaiter;

        /// <summary>
        /// Initializes a new task.
        /// </summary>
        public WebTask() => Awaiter = new WebTaskAwaiter(this);

        /// <summary>
        /// Initializes a new task with the given Action.
        /// </summary>
        /// <param name="action">
        /// The delegate that represents the code to execute in the task, typically an external function call which
        /// takes a handle to the task for use in a callback function when the asynchronous operation completes.
        /// </param>
        internal WebTask(Action<IntPtr> action)
        {
            Awaiter = new WebTaskAwaiter(this);
            GCHandle handle = GCHandle.Alloc(this);
            IntPtr taskPtr = GCHandle.ToIntPtr(handle);
            action(taskPtr);
        }

        /// <summary>
        /// Waits for the task to complete execution.
        /// The method is intended to support compatibility with Unity coroutines.
        /// </summary>
        /// <returns>An enumerator that is iterable until the task completes, at which point iteration will stop.</returns>
        public IEnumerator WaitForCompletion()
        {
            while (!IsCompleted)
            {
                yield return null;
            }
        }

        /// <summary>
        /// Creates a continuation that executes asynchronously when the target task completes.
        /// </summary>
        /// <param name="action">
        /// An action to run when the task completes. When run, the delegate will be passed the completed task as an
        /// argument.
        /// </param>
        /// <returns>A new continuation task.</returns>
        public WebTask ContinueWith(Action<WebTask> action)
        {
            var continuationTask = new WebTask();
            OnCompleted(() =>
            {
                action(this);
                continuationTask.SetResult();
            });
            return continuationTask;
        }

        internal void GetResult()
        {
            if (!IsCompleted)
            {
                throw new InvalidOperationException("Task is not completed");
            }

            if (IsFaulted)
            {
                throw this.Exception;
            }
        }

        internal void SetResult()
        {
            if (IsCompleted)
            {
                throw new InvalidOperationException("SetResult failed. Task is already completed.");
            }

            IsCompleted = true;
            Finished?.Invoke();
        }

        internal void SetException(Exception e)
        {
            if (IsCompleted)
            {
                throw new InvalidOperationException("SetException failed. Task is already completed.", e);
            }

            IsCompleted = true;
            Exception = e;
            Finished?.Invoke();
        }

        internal void OnCompleted(Action continuation)
        {
            if (IsCompleted)
            {
                continuation();
            }
            else
            {
                Finished += continuation;
            }
        }
    }
}
