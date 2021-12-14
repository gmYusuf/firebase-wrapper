using UnityEngine;
using System.Collections;
using System;

namespace FirebaseUnityWrapper.Database.Event
{
    internal class EventPrimitive<T> : AbstractEvent<T>
    {
        public EventPrimitive(AndroidJavaObject javaObject) : base(javaObject) { }

        public override IEvent<T> AddValueEventListener(Action<T> valueEventListener)
        {
            JavaObject = Call<AndroidJavaObject>("addValueEventListener", new ValueEventListenerWrapper<T>(valueEventListener));
            return this;
        }
    }


    internal class EventPrimitiveInt : EventPrimitive<int>
    {
        public EventPrimitiveInt(AndroidJavaObject javaObject) : base(javaObject) { }
    }


    internal class TaskPrimitiveByteArray : EventPrimitive<byte[]>
    {
        public TaskPrimitiveByteArray(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}
 