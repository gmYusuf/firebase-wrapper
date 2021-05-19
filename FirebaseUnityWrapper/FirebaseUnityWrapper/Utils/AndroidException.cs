using System;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidException : Exception
    {

        public AndroidException(string message) : base(message) { }

        internal AndroidException(int errorCode) : base()
        {
            ErrorCode = errorCode;
        }

        internal AndroidException(AndroidJavaObject javaObject) : base()
        {
            JavaException = javaObject;
        }

        internal AndroidJavaObject JavaException { get; }

        public int ErrorCode { get; }

        public string WrappedExceptionMessage => JavaException.Call<AndroidJavaObject>("getMessage").AsString();

        public string WrappedCauseMessage => JavaException
            .Call<AndroidJavaObject>("getCause")
            ?.Call<AndroidJavaObject>("getMessage")
            .AsString();
    }
}
