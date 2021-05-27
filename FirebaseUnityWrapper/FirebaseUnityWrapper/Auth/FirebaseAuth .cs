namespace FirebaseUnityWrapper.Auth
{
    using AndroidUtils;
    using UnityEngine;

    // Wrapper for com.google.firebase.auth.FirebaseAuth
    public class FirebaseAuth : JavaObjectWrapper
    {
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.FirebaseAuth");

        public FirebaseAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseAuth Instance => androidJavaClass.CallStatic<AndroidJavaObject>("getInstance").AsWrapper<FirebaseAuth>();

        public FirebaseUser CurrentUser => CallAsWrapper<FirebaseUser>("getCurrentUser");
    }
}
