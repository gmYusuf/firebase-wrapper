using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Database.Event
{

    internal class EventJavaObjectWrapper<T> : EventWrapper<T> where T : JavaObjectWrapper
    {
        public EventJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsWrapper<T>) { }
    }
}
