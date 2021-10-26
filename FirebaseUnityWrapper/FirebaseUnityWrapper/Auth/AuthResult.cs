using AndroidUtils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class AuthResult : JavaObjectWrapper
    {
        public AuthResult(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.AuthResult");

        public AdditionalUserInfo AdditionalUserInfo => CallAsWrapper<AdditionalUserInfo>("getAdditionalUserInfo");

        public FirebaseUser User => CallAsWrapper<FirebaseUser>("getUser");

        public AuthCredential Credential => CallAsWrapper<AuthCredential>("getCredential");

    }
}
