using UnityEngine;
using System.Collections;
using AndroidUtils;
using System;

namespace FirebaseUnityWrapper.Database.Event
{
    internal abstract class AbstractEvent<T> : JavaObjectWrapper, IEvent<T>
    {
        public AbstractEvent(AndroidJavaObject javaObject) : base(javaObject) { }

        public IEvent<T> AddChildEventListener(Action<Exception> childEventListener)
        {
            throw new NotImplementedException();
        }

        public void AddListenerForSingleValueEvent(Action<T> listenerForSingleValueEvent)
        {
            throw new NotImplementedException();
        }
 
        abstract public IEvent<T> AddValueEventListener(Action<T> valueEventListener );
 
    }
}