using UnityEngine;

namespace AndroidUtils
{
    public class AndroidBitmapFactory : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.graphics.BitmapFactory";
        private static readonly AndroidJavaClass bitmapFactoryClass = new AndroidJavaClass(CLASS_NAME);

        [UnityEngine.Scripting.Preserve]
        public AndroidBitmapFactory(AndroidJavaObject javaObject) : base(javaObject) { }
 
        public static AndroidJavaObject DecodeFile (string fileName) => bitmapFactoryClass.CallStatic<AndroidJavaObject>("decodeFile", fileName);


    }
}
