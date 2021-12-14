using UnityEngine;
using System.Collections;
using AndroidUtils;
using GMSTasks;

namespace FirebaseUnityWrapper.Database.Event
{
    internal static class EventUtils
    {

        public static IEvent<T> AsIEvent<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper => new EventJavaObjectWrapper<T>(javaObject);

        public static IEvent<T> CallAsIEvent<T>(this JavaObjectWrapper javaObject, string methodName, params object[] args) where T : JavaObjectWrapper =>
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsIEvent<T>();

        public static IEvent<Void> AsVoidIEvent(this AndroidJavaObject javaObject) => new EventVoidWrapper(javaObject);

        public static IEvent<Void> CallAsVoidIEvent(this JavaObjectWrapper javaObject, string methodName, params object[] args) =>
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsVoidIEvent();

        public static IEvent<byte[]> AsByteArrayIEvent(this AndroidJavaObject javaObject) => new TaskPrimitiveByteArray(javaObject);

        public static IEvent<byte[]> CallAsByteArrayIEvent(this JavaObjectWrapper javaObject, string methodName, params object[] args) =>
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsByteArrayIEvent();
    }
}