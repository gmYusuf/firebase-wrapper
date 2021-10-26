using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Auth
{
    public class FacebookAuthProvider : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.FacebookAuthProvider");
        public FacebookAuthProvider(AndroidJavaObject javaObject) : base(javaObject) { }

        public AuthCredential Credential(string accessToken) => androidJavaClass.CallStaticAsWrapper<AuthCredential>("getCredential", accessToken);

        public static string FACEBOOK_SIGN_IN_METHOD => androidJavaClass.GetStatic<string>("FACEBOOK_SIGN_IN_METHOD");
        public static string PROVIDER_ID => androidJavaClass.GetStatic<string>("PROVIDER_ID");
    }
}