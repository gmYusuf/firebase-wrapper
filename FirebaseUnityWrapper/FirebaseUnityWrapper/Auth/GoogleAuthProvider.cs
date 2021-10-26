using UnityEngine;
using AndroidUtils;

namespace FirebaseUnityWrapper.Auth
{
    public class GoogleAuthProvider : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.GoogleAuthProvider");
        public GoogleAuthProvider(AndroidJavaObject javaObject) : base(javaObject) { }

        public AuthCredential Credential(string idToken, string accessToken) => androidJavaClass.CallStaticAsWrapper<AuthCredential>("getCredential", idToken, accessToken);

        public static string GOOGLE_SIGN_IN_METHOD => androidJavaClass.GetStatic<string>("GOOGLE_SIGN_IN_METHOD");
        public static string PROVIDER_ID => androidJavaClass.GetStatic<string>("PROVIDER_ID");
    }
}