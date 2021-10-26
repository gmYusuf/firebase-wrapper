using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class AdditionalUserInfo :  JavaObjectWrapper
    {
        public AdditionalUserInfo(AndroidJavaObject javaObject) : base(javaObject) { }
        public string ProviderId => Call<string>("getProviderId");
        public string Username => Call<string>("getUsername");
        public bool IOSBundle => Call<bool>("isNewUser");
    }
}