using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class AuthCredential : JavaObjectWrapper
    {
        public AuthCredential(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Provider => Call<string>("getProvider");
        public string SignInMethod => Call<string>("getSignInMethod");


    }
}