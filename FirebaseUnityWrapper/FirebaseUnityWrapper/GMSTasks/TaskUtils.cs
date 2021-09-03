using GMSTasks;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace FirebaseUnityWrapper.GMSTasks
{
    internal static class TaskUtils
    {
        public static ITask<T> AsITask<T>(this AndroidJavaObject javaObject) where T: AndroidJavaObject => new TaskJavaObjectWrapper<T>(javaObject);
    }
}
