using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Firebase
{
    public class FirebaseOptions : JavaObjectWrapper
    {
        public FirebaseOptions(AndroidJavaObject javaObject) : base(javaObject) { }
        public string ApiKey => Call<string>("getApiKey");
        public string ApplicationId => Call<string>("getApplicationId");
        public string DatabaseUrl => Call<string>("getDatabaseUrl");
        public string GcmSenderId => Call<string>("getGcmSenderId");
        public string ProjectId => Call<string>("getProjectId");
        public string StorageBucket => Call<string>("getStorageBucket");


    }
}