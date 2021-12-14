using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.FireStore
{
    public class FieldPath : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.firestore.FieldPath");

        public FieldPath(AndroidJavaObject javaObject) : base(javaObject) { }
        public static FieldPath DocumentId => androidJavaClass.CallStaticAsWrapper<FieldPath>("documentId");
        public static FieldPath Of(string name) => androidJavaClass.CallStaticAsWrapper<FieldPath>("of", name);

    }
}