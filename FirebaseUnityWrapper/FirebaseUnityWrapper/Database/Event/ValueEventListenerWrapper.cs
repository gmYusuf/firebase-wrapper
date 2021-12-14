using UnityEngine;
using System.Collections;
using System;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database.Event
{
    internal class ValueEventListenerConverterWrapper<T> : AndroidJavaProxy
    {
        private readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;

 

        internal ValueEventListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.google.firebase.database.ValueEventListener")
        {
            mListener = listener;
            mConverter = func;


        }

        public void onDataChange(AndroidJavaObject snapshot)
        {
            T convertedResult = mConverter(snapshot);
            mListener.Invoke(convertedResult);
        }
    }

    internal class ValueEventListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;


        public ValueEventListenerWrapper(Action<T> listener) : base("com.google.firebase.database.ValueEventListener")
        {
            mListener = listener;
     
        }

        // WARNING: DO NO MODIFY METHOD NAME onSuccess, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onDataChange(T result)
        {
            mListener.Invoke(result);
        }

        
        
    }
}