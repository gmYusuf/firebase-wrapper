using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database
{
    public class FirebaseDatabase : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.database.FirebaseDatabase");

        public FirebaseDatabase(AndroidJavaObject javaObject) : base(javaObject) { }

        public static FirebaseDatabase Instance => androidJavaClass.CallStaticAsWrapper<FirebaseDatabase>("getInstance");

        public static FirebaseDatabase GetInstance(string url) => androidJavaClass.CallStaticAsWrapper<FirebaseDatabase>("getInstance", url);

        public DatabaseReference Reference => CallAsWrapper<DatabaseReference>("getReference");

        public DatabaseReference ReferenceForPath(string path) => CallAsWrapper<DatabaseReference>("getReference", path);
        public DatabaseReference ReferenceForURL(string URL) => CallAsWrapper<DatabaseReference>("getReferenceFromUrl", URL);

    }
}
 