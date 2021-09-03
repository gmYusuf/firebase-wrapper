using AndroidUtils;
using FirebaseUnityWrapper.GMSTasks;
using GMSTasks;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{

    // Wrapper for com.google.firebase.auth.FirebaseAuth
    public class FirebaseAuth : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.FirebaseAuth");

        public FirebaseAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseAuth Instance => androidJavaClass.CallStatic<AndroidJavaObject>("getInstance").AsWrapper<FirebaseAuth>();

        public FirebaseUser CurrentUser => CallAsWrapper<FirebaseUser>("getCurrentUser");

        public ITask<AuthResult> CreateUserWithEmailAndPassword(string email, string password) => Call<AndroidJavaObject>("createUserWithEmailAndPassword", email, password).AsITask<AuthResult>();

        public ITask<AuthResult> SignInWithEmailAndPassword(string email, string password) => Call<AndroidJavaObject>("signInWithEmailAndPassword", email, password).AsITask<AuthResult>();

        public ITask<AuthResult> SignInAnonymously() => Call<AndroidJavaObject>("signInAnonymously").AsITask<AuthResult>();

        public ITask<AuthResult> SignInWithCustomToken(string token) => Call<AndroidJavaObject>("signInWithCustomToken", token).AsITask<AuthResult>();
    }
}
