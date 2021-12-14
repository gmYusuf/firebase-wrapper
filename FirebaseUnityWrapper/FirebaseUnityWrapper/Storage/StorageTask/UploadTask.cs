using UnityEngine;
using System.Collections;
using AndroidUtils;
using GMSTasks;
using System;

namespace FirebaseUnityWrapper.Storage.StorageTask
{
    public class UploadTask  : CancellableTask<UploadTask>
    {
        public UploadTask(AndroidJavaObject javaObject) : base(javaObject) { }
        public void OnCancelled() => Call("onCancelled");
        public void ResetState() => Call("resetState");
        public void Schedule() => Call("schedule");
        public void OnOnFailure() => Call("onFailure");
        public void OnPaused() => Call("onPaused");
        public void OnProgress() => Call("onProgress");
        public void OnQueued() => Call("onQueued");
        public void onSuccess() => Call("onSuccess");

        public override UploadTask Result => Call<UploadTask>("getResult");
        public override ITask<UploadTask> AddOnSuccessListener(Action<UploadTask> onSuccessListener)
        {
            JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", new OnSuccessListenerWrapper<UploadTask>(onSuccessListener));
            return this;
        }
        public class TaskSnapshot : JavaObjectWrapper
        {
            public TaskSnapshot(AndroidJavaObject javaObject) : base(javaObject) { }
            public long BytesTransferred => Call<long>("getBytesTransferred");
            public long TotalByteCount => Call<long>("getTotalByteCount");
            public StorageMetadata gMetadata => CallAsWrapper<StorageMetadata>("getMetadata");


        }
    }
}