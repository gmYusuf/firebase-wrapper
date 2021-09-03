using AndroidUtils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class AuthResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public AuthResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public FirebaseUser User => JavaObject.AsWrapper<FirebaseUser>();
    }
}
