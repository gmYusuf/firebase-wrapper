using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Auth
{
    public class FirebaseUser : JavaObjectWrapper
    {
        public FirebaseUser(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}
