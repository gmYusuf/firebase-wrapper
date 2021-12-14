using UnityEngine;
using System.Collections;
using AndroidUtils;
using System.Collections.Generic;

namespace FirebaseUnityWrapper.Firebase
{
    public class FirebaseApp : JavaObjectWrapper
    {
        public FirebaseApp(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.Firebase.FirebaseApp");

        public static FirebaseApp Instance => androidJavaClass.CallStaticAsWrapper<FirebaseApp>("getInstance");
        public static FirebaseApp GetInstance(string name) => androidJavaClass.CallStaticAsWrapper<FirebaseApp>("getInstance");
        public static FirebaseApp InitializeApp() => androidJavaClass.CallStaticAsWrapper<FirebaseApp>("initializeApp",AndroidContext.ActivityContext);
        public static FirebaseApp InitializeApp(FirebaseOptions firebaseOptions) => androidJavaClass.CallStaticAsWrapper<FirebaseApp>("initializeApp",AndroidContext.ActivityContext,firebaseOptions);
        public static FirebaseApp InitializeApp(FirebaseOptions firebaseOptions, string name) => androidJavaClass.CallStaticAsWrapper<FirebaseApp>("initializeApp",AndroidContext.ActivityContext,firebaseOptions, name);
        public static IList<FirebaseApp> Apps => androidJavaClass.Call<IList<FirebaseApp>>("getApps");
        public string Name => Call<string>("getName");
        public void AutomaticResourceManagementEnabled(bool enabled) => Call<string>("setAutomaticResourceManagementEnabled",enabled);
        public FirebaseOptions Optionsren => CallAsWrapper<FirebaseOptions>("getApps",AndroidContext.ActivityContext);

    }
}