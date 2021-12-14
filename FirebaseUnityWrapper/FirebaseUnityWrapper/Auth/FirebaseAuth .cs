using AndroidUtils;
using GMSTasks;
using System;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{

    // Wrapper for com.google.firebase.auth.FirebaseAuth
    public class FirebaseAuth : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.FirebaseAuth");

        public FirebaseAuth(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseAuth Instance => androidJavaClass.CallStaticAsWrapper<FirebaseAuth>("getInstance");

        public FirebaseUser CurrentUser => CallAsWrapper<FirebaseUser>("getCurrentUser");
        public void SignOut() => Call("signOut");
        public void UseAppLanguage() => Call("useAppLanguage");

        public ITask<AuthResult> CreateUserWithEmailAndPassword(string email, string password) => this.CallAsITask<AuthResult>("createUserWithEmailAndPassword", email, password);

        public ITask<AuthResult> SignInWithEmailAndPassword(string email, string password) => this.CallAsITask<AuthResult>("signInWithEmailAndPassword", email, password);

        public ITask<AuthResult> SignInAnonymously() => this.CallAsITask<AuthResult>("signInAnonymously");

        public ITask<AuthResult> SignInWithCustomToken(string token) => this.CallAsITask<AuthResult>("signInWithCustomToken", token);

        public ITask<SignInMethodQueryResult> FetchSignInMethodsForEmail(string email) => this.CallAsITask<SignInMethodQueryResult>("fetchSignInMethodsForEmail ", email);

        public ITask<AuthResult> CheckActionCode(string code) => this.CallAsITask<AuthResult>("checkActionCode", code);
        public ITask<global::AndroidUtils.Void> ConfirmPasswordReset(string code, string newPassword) => this.CallAsVoidITask("confirmPasswordReset", code, newPassword);
        public ITask<String> VerifyPasswordResetCode(string code) => CallAsWrapper<TaskPrimitive<string>>("verifyPasswordResetCode", code);

        



    }
}
