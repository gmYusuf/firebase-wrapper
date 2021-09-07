using System;
using UnityEngine;

namespace GMSTasks
{

    internal class TaskPrimitive<T> : AbstractTask<T>
    {
        public TaskPrimitive(AndroidJavaObject javaObject) : base(javaObject) { }

        public override T Result => Call<T>("getResult");

        public override ITask<T> AddOnSuccessListener(Action<T> onSuccessListener)
        {
            JavaObject = Call<AndroidJavaObject>("addOnSuccessListener", new OnSuccessListenerWrapper<T>(onSuccessListener));
            return this;
        }
    }

    
    internal class TaskPrimitiveInt : TaskPrimitive<int>
    {
        public TaskPrimitiveInt(AndroidJavaObject javaObject) : base(javaObject) { }
    }


    internal class TaskPrimitiveByteArray : TaskPrimitive<byte[]>
    {
        public TaskPrimitiveByteArray(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}
