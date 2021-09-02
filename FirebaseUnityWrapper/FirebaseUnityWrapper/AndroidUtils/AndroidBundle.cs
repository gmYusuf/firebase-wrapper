using UnityEngine;

namespace AndroidUtils
{

    public class AndroidBundle : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidBundle(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bundle => JavaObject;
    }
}
