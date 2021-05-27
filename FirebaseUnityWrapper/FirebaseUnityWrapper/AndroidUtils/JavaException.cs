using AndroidUtils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FirebaseUnityWrapper.AndroidUtils
{
    public class JavaException : Exception
    {



        private JavaObjectWrapper javaObjectWrapper;

        public JavaException(AndroidJavaObject javaException)
        {
            javaObjectWrapper = new JavaObjectWrapper(javaException);
        }
    }
}
