using System;
using System.Runtime.CompilerServices;

namespace Runtime
{
    public readonly struct WebTaskBuilder
    {
        // required member
        public WebTask Task { get; }

        private WebTaskBuilder(WebTask task) => Task = task;

        // required member
        public void SetException(Exception e) => Task.SetException(e);

        // required member
        public void SetResult() => Task.SetResult();

        // required member
        public static WebTaskBuilder Create() => new WebTaskBuilder(new WebTask());

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
