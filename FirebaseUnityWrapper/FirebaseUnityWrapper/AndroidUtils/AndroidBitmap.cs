using UnityEngine;

namespace AndroidUtils
{

    public class AndroidBitmap : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidBitmap(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bitmap => JavaObject;
    }
}
