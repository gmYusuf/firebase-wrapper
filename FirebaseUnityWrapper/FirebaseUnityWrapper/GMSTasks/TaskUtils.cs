using AndroidUtils;
using GMSTasks;
using UnityEngine;

namespace GMSTasks
{
    internal static class TaskUtils
    {
        public static ITask<T> AsITask<T>(this AndroidJavaObject javaObject) where T: JavaObjectWrapper => new TaskJavaObjectWrapper<T>(javaObject);

        public static ITask<T> CallAsITask<T>(this JavaObjectWrapper javaObject, string methodName, params object[] args) where T : JavaObjectWrapper => 
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsITask<T>();

        public static ITask<Void> AsVoidITask(this AndroidJavaObject javaObject) => new TaskVoidWrapper(javaObject);

        public static ITask<Void> CallAsVoidITask(this JavaObjectWrapper javaObject, string methodName, params object[] args) =>
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsVoidITask();

        public static ITask<byte[]> AsByteArrayITask(this AndroidJavaObject javaObject) => new TaskPrimitiveByteArray(javaObject);

        public static ITask<byte[]> CallAsByteArrayITask(this JavaObjectWrapper javaObject, string methodName, params object[] args) =>
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsByteArrayITask();
    }
}
