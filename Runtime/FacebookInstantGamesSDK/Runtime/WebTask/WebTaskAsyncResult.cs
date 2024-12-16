using System;
using System.Runtime.InteropServices;

namespace Runtime
{
    internal static class WebTaskAsyncResult
    {
        [MonoPInvokeCallback]
        public static void HandleSuccess(IntPtr taskPtr)
        {
            GCHandle handle = GCHandle.FromIntPtr(taskPtr);
            var task = handle.Target as WebTask;
            task.SetResult();
            handle.Free();
        }

        [MonoPInvokeCallback]
        public static void HandleSuccess(IntPtr taskPtr, bool result) => HandleSuccess<bool>(taskPtr, result);

        [MonoPInvokeCallback]
        public static void HandleSuccess(IntPtr taskPtr, double result) => HandleSuccess<double>(taskPtr, result);

        [MonoPInvokeCallback]
        public static void HandleSuccess(IntPtr taskPtr, string result) => HandleSuccess<string>(taskPtr, result);

        internal static void HandleSuccess<T>(IntPtr taskPtr, T result)
        {
            GCHandle handle = GCHandle.FromIntPtr(taskPtr);
            var task = (WebTask<T>) handle.Target;
            task.SetResult(result);
            handle.Free();
        }

        public static void HandleFailure(IntPtr taskPtr, Exception error)
        {
            GCHandle handle = GCHandle.FromIntPtr(taskPtr);
            var task = (WebTask) handle.Target;
            task.SetException(error);
            handle.Free();
        }

        [MonoPInvokeCallback]
        public static void HandleBoolFailure(IntPtr taskPtr, Exception error) => HandleFailure<bool>(taskPtr, error);

        [MonoPInvokeCallback]
        public static void HandleNumberFailure(IntPtr taskPtr, Exception error) => HandleFailure<double>(taskPtr, error);

        [MonoPInvokeCallback]
        public static void HandleStringFailure(IntPtr taskPtr, Exception error) => HandleFailure<string>(taskPtr, error);

        public static void HandleFailure<T>(IntPtr taskPtr, Exception error)
        {
            GCHandle handle = GCHandle.FromIntPtr(taskPtr);
            var task = (WebTask<T>) handle.Target;
            task.SetException(error);
            handle.Free();
        }
    }
}
