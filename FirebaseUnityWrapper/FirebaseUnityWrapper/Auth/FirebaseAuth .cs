using AndroidUtils;
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

        public ITask<FirebaseUser> CreateUserWithEmailAndPassword(string email, string password)
        {
            var javaTask = Call<AndroidJavaObject>("createUserWithEmailAndPassword", email, password);
            return new TaskJavaObjectWrapper<FirebaseUser>(javaTask);
        }
    }
}
