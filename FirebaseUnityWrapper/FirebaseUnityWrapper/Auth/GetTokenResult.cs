using AndroidUtils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class GetTokenResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GetTokenResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Token => Call<string>("getToken");
    }
}
