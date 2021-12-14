using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Database.Event
{
    internal class EventVoidWrapper : EventWrapper<Void>
    {
        public EventVoidWrapper(AndroidJavaObject javaObject) : base(javaObject, (jObject) => Void.INSTANCE) { }
    }
}