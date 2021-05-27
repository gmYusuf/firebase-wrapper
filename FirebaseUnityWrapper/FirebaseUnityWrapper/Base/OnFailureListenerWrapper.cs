namespace FirebaseUnityWrapper.Base
{
    using System;
    using UnityEngine;

    // Wrapper for com.google.android.gms.tasks.OnFailureListener
    internal class OnFailureListenerWrapper : AndroidJavaProxy
    {

        private readonly Action<Exception> mListener;

        internal OnFailureListenerWrapper(Action<Exception> listener) : base("com.google.android.gms.tasks.OnFailureListener")
        {
            mListener = listener;
        }

        public void onFailure(AndroidJavaObject javaException)
        {
            mListener.Invoke(javaException.AsException());
        }
    }
}
