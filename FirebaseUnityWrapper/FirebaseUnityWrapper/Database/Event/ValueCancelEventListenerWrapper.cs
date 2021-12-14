using UnityEngine;
using System.Collections;
using System;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database.Event
{
    internal class ValueCancelEventListenerConverterWrapper <T> : AndroidJavaProxy
    {
        private readonly Action<T> mListener;
        private readonly Func<AndroidJavaObject, T> mConverter;



        internal ValueCancelEventListenerConverterWrapper(Action<T> listener, Func<AndroidJavaObject, T> func) : base("com.google.firebase.database.ValueEventListener")
        {
            mListener = listener;
            mConverter = func;


        }

        public void onCancelled(AndroidJavaObject snapshot)
        {
            T convertedResult = mConverter(snapshot);
            mListener.Invoke(convertedResult);
        }
    }

    internal class ValueCancelEventListenerWrapper<T> : AndroidJavaProxy
    {
        protected readonly Action<T> mListener;


        public ValueCancelEventListenerWrapper(Action<T> listener) : base("com.google.firebase.database.ValueEventListener")
        {
            mListener = listener;
     
        }

        // WARNING: DO NO MODIFY METHOD NAME onSuccess, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onCancelled(T result)
        {
            mListener.Invoke(result);
        }

        
        
    }
}