using System;
using UnityEngine;

namespace FirebaseUnityWrapper.Database.Event
{ 
    internal class EventWrapper<T> : AbstractEvent<T>
    {

        private readonly Func<AndroidJavaObject, T> mConverter;
 
        internal EventWrapper(AndroidJavaObject javaObject, Func<AndroidJavaObject, T> func) : base(javaObject)
        {
            mConverter = func;
        } 

        override public IEvent<T> AddValueEventListener(Action<T> onChangeListener)
        {
            var listenerWrapper = new ValueEventListenerConverterWrapper<T>(onChangeListener, mConverter);
            JavaObject = Call<AndroidJavaObject>("addValueEventListener", listenerWrapper);
            return this;
        }
     
    }

    
}