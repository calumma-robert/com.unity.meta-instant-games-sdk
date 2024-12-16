using System;
using System.Runtime.CompilerServices;

namespace Runtime
{
    /// <summary>
    /// Represents an object that waits for the completion of an asynchronous task and provides a parameter for the result.
    /// </summary>
    /// <typeparam name="T">The result for the task.</typeparam>
    public readonly struct WebTaskAwaiter<T> : ICriticalNotifyCompletion
    {
        /// <summary>
        /// Indicates whether the asynchronous task has completed. Required member for a task awaiter.
        /// </summary>
        public bool IsCompleted { get => Task.IsCompleted; }

        /// <summary>
        /// Indicates whether the task completed due to an unhandled exception.
        /// </summary>
        public bool IsFaulted { get => Task.IsFaulted; }

        private WebTask<T> Task { get; }

        /// <summary>
        /// Initializes a new task awaiter with the given task.
        /// </summary>
        /// <param name="task">Represents the task to await.</param>
        public WebTaskAwaiter(WebTask<T> task) => Task = task;

        /// <summary>
        /// Ends the wait for the completion of the asynchronous task. Required member for a task awaiter.
        /// </summary>
        /// <returns>The result of the completed task.</returns>
        public T GetResult() => Task.GetResult();

        /// <summary>
        /// Sets the action to perform when the task awaiter object stops waiting for the asynchronous task to complete.
        /// Required member for a task awaiter.
        /// This API supports the product infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="continuation">The action to perform when the wait operation completes.</param>
        public void OnCompleted(Action continuation) => Task.OnCompleted(continuation);

        /// <summary>
        /// Sets the action to perform when the task awaiter object stops waiting for the asynchronous task to complete.
        /// Required member for a task awaiter.
        /// This API supports the product infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="continuation">The action to perform when the wait operation completes.</param>
        public void UnsafeOnCompleted(Action continuation) => Task.OnCompleted(continuation);
    }
}
