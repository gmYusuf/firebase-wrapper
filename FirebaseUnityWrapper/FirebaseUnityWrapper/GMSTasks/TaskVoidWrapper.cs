using AndroidUtils;
using UnityEngine;

namespace GMSTasks
{

    internal class TaskVoidWrapper : TaskWrapper<Void>
    {
        public TaskVoidWrapper(AndroidJavaObject javaObject) : base(javaObject, (jObject) => Void.INSTANCE) { }
    }
}
