using UnityEngine;
using System.Collections;
using GMSTasks;
using System;
using AndroidUtils;


namespace FirebaseUnityWrapper.Storage.StorageTask
{
    public class StorageTask<T> : ControllableTask<T>
    {
        public StorageTask(AndroidJavaObject javaObject) : base(javaObject) { }

        public void OnCancelled() => Call("onCancelled");
        public void OnOnFailure() => Call("onFailure");
        public void OnPaused() => Call("onPaused");
        public void OnProgress() => Call("onProgress");
        public void OnQueued() => Call("onQueued");
        public void OnSuccess() => Call("onSuccess");
 
    }
}