using AndroidUtils;
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
        public static ITask<T> AsITask<T>(this AndroidJavaObject javaObject) where T: JavaObjectWrapper => new TaskJavaObjectWrapper<T>(javaObject);

        public static ITask<T> CallAsITask<T>(this JavaObjectWrapper javaObject, string methodName, params object[] args) where T : JavaObjectWrapper => 
            javaObject.Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsITask<T>();
    }
}
