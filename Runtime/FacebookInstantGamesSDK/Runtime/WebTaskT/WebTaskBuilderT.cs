using System;
using System.Runtime.CompilerServices;

namespace Runtime
{
    public readonly struct WebTaskBuilder<T>
    {
        // required member
        public WebTask<T> Task { get; }

        private WebTaskBuilder(WebTask<T> task) => Task = task;

        // required member
        public void SetException(Exception e) => Task.SetException(e);

        // required member
        public void SetResult(T result) => Task.SetResult(result);

        // required member
        public static WebTaskBuilder<T> Create() => new WebTaskBuilder<T>(new WebTask<T>());

        // required member
        public void Start<TStateMachine>(ref TStateMachine stateMachine)
            where TStateMachine : IAsyncStateMachine => stateMachine.MoveNext();

        // required member
        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine => awaiter.OnCompleted(stateMachine.MoveNext);

        // required member
        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine => awaiter.UnsafeOnCompleted(stateMachine.MoveNext);

        // required member
        public void SetStateMachine(IAsyncStateMachine _)
        {
            // method is required, but there's nothing to do here
        }
    }
}
