using UnityEngine;
using System.Collections;
using AndroidUtils;
using System.Collections.Generic;

namespace FirebaseUnityWrapper.Storage
{
    public class ListResult : JavaObjectWrapper
    {
        public ListResult(AndroidJavaObject javaObject) : base(javaObject) { }
        public IList<StorageReference> Items =>
       Call<AndroidJavaObject>("getItems").AsListFromWrappable<StorageReference>();
        public string PageToken => Call<string>("getPageToken");
        public IList<StorageReference> Prefixes =>  
           Call<AndroidJavaObject>("getPrefixes").AsListFromWrappable<StorageReference>();
    }
}