﻿using UnityEngine;
using System.Collections;
using GMSTasks;
using System;
using AndroidUtils;

namespace FirebaseUnityWrapper.Storage.StorageTask
{
    public abstract class CancellableTask<T> : JavaObjectWrapper, ITask<T>
    {
        public CancellableTask(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool Cancel =>  Call<bool>("cancel");

        public bool Complete => Call<bool>("isComplete"); 

        public bool Successful => Call<bool>("isSuccessful"); 

        public bool Canceled => Call<bool>("isCanceled");

        abstract public T Result { get; }

        public Exception Exception => Call<AndroidJavaObject>("getException").AsException();

        public ITask<T> AddOnFailureListener(Action<Exception> onFailureListener)
        {
            var listenerWrapper = new OnFailureListenerWrapper(onFailureListener);
            JavaObject = Call<AndroidJavaObject>("addOnFailureListener", listenerWrapper);
            return this;
        }

        abstract public ITask<T> AddOnSuccessListener(Action<T> onSuccessListener);

    }
}