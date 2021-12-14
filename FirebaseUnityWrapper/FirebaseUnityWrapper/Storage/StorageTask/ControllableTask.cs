using UnityEngine;
using System.Collections;
using GMSTasks;
using System;

namespace FirebaseUnityWrapper.Storage.StorageTask
{
    public class ControllableTask<T> : CancellableTask<T>
    {
        public ControllableTask(AndroidJavaObject javaObject) : base(javaObject) { }

        public override T Result => Call<T>("getResult");
        public override ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", new OnSuccessListenerWrapper<T>(onSuccessListener));
            return this;
        }
    }
}