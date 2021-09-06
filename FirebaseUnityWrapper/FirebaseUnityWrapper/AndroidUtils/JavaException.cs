using AndroidUtils;
using System;
using UnityEngine;

namespace FirebaseUnityWrapper.AndroidUtils
{
    public class JavaException : Exception
    {

        private class JavaExceptionWrapper : JavaObjectWrapper
        {
            public JavaExceptionWrapper(AndroidJavaObject javaObject) : base(javaObject) { }
        }

        private JavaObjectWrapper javaObjectWrapper;

        public JavaException(AndroidJavaObject javaException)
        {
            javaObjectWrapper = new JavaExceptionWrapper(javaException);
        }
    }
}
