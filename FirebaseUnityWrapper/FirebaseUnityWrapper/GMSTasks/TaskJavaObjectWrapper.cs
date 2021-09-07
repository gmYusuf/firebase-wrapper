using AndroidUtils;
using UnityEngine;

namespace GMSTasks
{

    internal class TaskJavaObjectWrapper<T> : TaskWrapper<T> where T : JavaObjectWrapper
    {
        public TaskJavaObjectWrapper(AndroidJavaObject javaObject) : base(javaObject, AndroidJavaObjectExtensions.AsWrapper<T>) { }
    }
}
