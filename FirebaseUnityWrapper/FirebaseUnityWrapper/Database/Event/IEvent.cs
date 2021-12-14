using UnityEngine;
using System.Collections;
using System;

namespace FirebaseUnityWrapper.Database.Event
{
    public interface IEvent<T>
    {

        IEvent<T> AddChildEventListener(Action<Exception> childEventListener);
        IEvent<T> AddValueEventListener(Action<T> changeEventListener);
        void AddListenerForSingleValueEvent(Action<T> listenerForSingleValueEvent);
    }
}