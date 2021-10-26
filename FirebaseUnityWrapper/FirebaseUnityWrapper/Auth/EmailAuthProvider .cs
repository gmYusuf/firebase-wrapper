using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Auth
{
    public class EmailAuthProvider : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.auth.EmailAuthProvider");
        public EmailAuthProvider(AndroidJavaObject javaObject) : base(javaObject) { }

        public AuthCredential Credential(string email, string password) => androidJavaClass.CallStaticAsWrapper<AuthCredential>("getCredential", email, password);

        public AuthCredential CredentialWithLink(string email, string emailLink) => androidJavaClass.CallStaticAsWrapper<AuthCredential>("getCredentialWithLink", email, emailLink);

    }
}