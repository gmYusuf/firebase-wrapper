using UnityEngine;

namespace AndroidUtils
{

    // Wrapper for android.accounts.Account
    public class AndroidAccount : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidAccount(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual AndroidJavaObject Account => JavaObject;

    }
}
