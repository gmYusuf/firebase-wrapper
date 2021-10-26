using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Auth
{
    public class EmailAuthCredential : JavaObjectWrapper
    {

        public EmailAuthCredential(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool CanHandleCodeInApp => Call<bool>("canHandleCodeInApp");
        public bool AndroidInstallApp => Call<bool>("getAndroidInstallApp");
        public string AndroidMinimumVersion => Call<string>("getAndroidMinimumVersion");
        public string AndroidPackageName => Call<string>("getAndroidPackageName");
        public string IOSBundle => Call<string>("getIOSBundle");
        public string Url => Call<string>("getUrl");


        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.google.firebase.auth.ActionCodeSettings$Builder") { }

            public ActionCodeSettings Build() => CallAsWrapper<ActionCodeSettings>("newBuilder");

        }
    }
}