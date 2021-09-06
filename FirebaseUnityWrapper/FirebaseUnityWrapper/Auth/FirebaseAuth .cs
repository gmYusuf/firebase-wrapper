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

        [UnityEngine.Scripting.Preserve]
        public FirebaseAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseAuth Instance => androidJavaClass.CallStaticAsWrapper<FirebaseAuth>("getInstance");

        public FirebaseUser CurrentUser => CallAsWrapper<FirebaseUser>("getCurrentUser");

        public ITask<AuthResult> CreateUserWithEmailAndPassword(string email, string password) => this.CallAsITask<AuthResult>("createUserWithEmailAndPassword", email, password);

        public ITask<AuthResult> SignInWithEmailAndPassword(string email, string password) => this.CallAsITask<AuthResult>("signInWithEmailAndPassword", email, password);

        public ITask<AuthResult> SignInAnonymously() => this.CallAsITask<AuthResult>("signInAnonymously");

        public ITask<AuthResult> SignInWithCustomToken(string token) => this.CallAsITask<AuthResult>("signInWithCustomToken", token);
    }
}
