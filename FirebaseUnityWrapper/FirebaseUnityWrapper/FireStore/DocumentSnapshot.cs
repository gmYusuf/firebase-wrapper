using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.FireStore
{
    public class DocumentSnapshot : JavaObjectWrapper
    {

        public DocumentSnapshot(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool Contains(FieldPath fieldPath) => Call<bool>("contains", fieldPath);
        public bool Contains(string field) => Call<bool>("contains", field);
        public bool Exists => Call<bool>("exists");
        public string ID => Call<string>("getId");
        public bool Boolean(string field) => Call<bool>("getBoolean", field);
        public SnapshotMetadata Metadata => CallAsWrapper<SnapshotMetadata>("getMetadata");
        public DocumentReference Reference => CallAsWrapper<DocumentReference>("getReference");
        public DocumentReference DocumentReference(string field) => CallAsWrapper<DocumentReference>("getDocumentReference", field);
         
    }
}