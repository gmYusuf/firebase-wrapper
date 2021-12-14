using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.FireStore
{
    public class SnapshotMetadata : JavaObjectWrapper
    {

        public SnapshotMetadata(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool PendingWrites => Call<bool>("hasPendingWrites");
        public bool FromCache => Call<bool>("isFromCache");
 

    }
}