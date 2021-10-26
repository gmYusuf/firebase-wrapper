using AndroidUtils;
using GMSTasks;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class FirebaseUser : JavaObjectWrapper
    {
        public FirebaseUser(AndroidJavaObject javaObject) : base(javaObject) { }

        public string DisplayName => Call<string>("getDisplayName");

        public string Email => Call<string>("getEmail");

        public string PhotoUrl => Call<AndroidJavaObject>("getPhotoUrl").AsString();

        public bool EmailVerified => Call<bool>("isEmailVerified");

        public string Uid => Call<string>("getUid");

        public string PhoneNumber => Call<string>("getPhoneNumber");

        public bool Anonymous => Call<bool>("isAnonymous");

        public ITask<GetTokenResult> GetIdToken(bool forceRefresh = true)
        {
            var javaObject = Call<AndroidJavaObject>("getIdToken", forceRefresh);
            return new TaskJavaObjectWrapper<GetTokenResult>(javaObject);
        }
        public ITask<AuthResult> LinkWithCredential(AuthCredential credential)
        {
            var javaObject = Call<AndroidJavaObject>("linkWithCredential", credential);
            return new TaskJavaObjectWrapper<AuthResult>(javaObject);
        }
        public ITask<Void> Delete => CallAsWrapper<TaskVoidWrapper>("delete");
     
        public ITask<AuthResult> Unlink(string provider)
        {
            var javaObject = Call<AndroidJavaObject>("unlink", provider);
            return new TaskJavaObjectWrapper<AuthResult>(javaObject);
        }
        public ITask<Void> SendEmailVerification() => CallAsWrapper<TaskVoidWrapper>("sendEmailVerification");
        public ITask<Void> SendEmailVerification(ActionCodeSettings actionCodeSettings) => CallAsWrapper<TaskVoidWrapper>("sendEmailVerification", actionCodeSettings);

    }
}
