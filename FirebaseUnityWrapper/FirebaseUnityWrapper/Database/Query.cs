using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database
{
    public class Query : JavaObjectWrapper
    {
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.database.Query");

        public Query(AndroidJavaObject javaObject) : base(javaObject) { }

    }
}