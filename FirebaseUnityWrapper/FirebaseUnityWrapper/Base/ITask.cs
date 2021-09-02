using System;

namespace FirebaseUnityWrapper.Base
{

    // Wrapper for com.google.android.gms.tasks.Task
    public interface ITask<T>
    {
        bool Complete { get; }

        bool Successful { get; }

        bool Canceled { get; }

        T Result { get; }

        Exception Exception { get; }

        ITask<T> AddOnFailureListener(Action<Exception> onFailureListener);

        ITask<T> AddOnSuccessListener(Action<T> onSuccessListener);
    }
}
