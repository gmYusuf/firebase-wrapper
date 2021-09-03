using AndroidUtils;
using GMSTasks;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class FirebaseUser : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
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
    }
}
