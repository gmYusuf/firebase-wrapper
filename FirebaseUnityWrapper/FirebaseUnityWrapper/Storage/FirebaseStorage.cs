using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Storage
{
    public class FirebaseStorage : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.storage.FirebaseStorage");

        public FirebaseStorage(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseStorage Instance => androidJavaClass.CallStaticAsWrapper<FirebaseStorage>("getInstance");

        public static FirebaseStorage GetInstance(string url) => androidJavaClass.CallStaticAsWrapper<FirebaseStorage>("getInstance", url);

        public StorageReference Reference => CallAsWrapper<StorageReference>("getReference");
    }
}
