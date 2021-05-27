namespace FirebaseUnityWrapper.Base
{
    using AndroidUtils;
    using System.Threading.Tasks;
    using UnityEngine;
    using System;

    internal abstract class AbstractTask<T> : JavaObjectWrapper, ITask<T>
    {

        [UnityEngine.Scripting.Preserve]
        public AbstractTask(AndroidJavaObject javaObject) : base(javaObject) { }

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

        public Task<T> Async()
        {
            var task = new TaskCompletionSource<T>();
            AddOnSuccessListener(task.SetResult);
            AddOnFailureListener(task.SetException);
            return task.Task;
        }
    }
}
