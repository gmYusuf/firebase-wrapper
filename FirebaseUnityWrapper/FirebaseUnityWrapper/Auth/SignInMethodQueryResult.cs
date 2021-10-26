using AndroidUtils;
using System.Collections.Generic;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class SignInMethodQueryResult : JavaObjectWrapper
    {
        public SignInMethodQueryResult(AndroidJavaObject javaObject) : base(javaObject) { }

         public List<string> SignInMethods => Call<List<string>>("getSignInMethods");
    }
}