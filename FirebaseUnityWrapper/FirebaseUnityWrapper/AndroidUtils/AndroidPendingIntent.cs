using UnityEngine;

namespace AndroidUtils
{

    public class AndroidPendingIntent : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidPendingIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Intent => JavaObject;
    }
}
