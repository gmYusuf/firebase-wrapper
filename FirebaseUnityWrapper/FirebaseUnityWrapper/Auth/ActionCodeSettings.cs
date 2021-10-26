using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Auth
{
    public class ActionCodeSettings : JavaObjectWrapper
    {
        public ActionCodeSettings(AndroidJavaObject javaObject) : base(javaObject) { }

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

            public ActionCodeSettings Build() => CallAsWrapper<ActionCodeSettings>("build");

            public Builder AndroidPackageName(string androidPackageName, bool installIfNotAvailable, string minimumVersion) 
                    => CallAsWrapper<Builder>("setAndroidPackageName", androidPackageName, installIfNotAvailable, minimumVersion);
            public Builder DynamicLinkDomain(string dynamicLinkDomain) => CallAsWrapper<Builder>("setDynamicLinkDomain", dynamicLinkDomain);
            public Builder HandleCodeInApp(bool status) => CallAsWrapper<Builder>("setHandleCodeInApp", status);
            public Builder IOSBundleId(string iOSBundleId) => CallAsWrapper<Builder>("setIOSBundleId", iOSBundleId);
            public Builder Url(string url) => CallAsWrapper<Builder>("setUrl", url);

        }
    
    }
}
