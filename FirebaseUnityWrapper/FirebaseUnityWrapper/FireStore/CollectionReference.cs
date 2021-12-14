using UnityEngine;
using System.Collections;
using AndroidUtils;
using GMSTasks;

namespace FirebaseUnityWrapper.FireStore
{
    public class CollectionReference : JavaObjectWrapper
    {

        public CollectionReference(AndroidJavaObject javaObject) : base(javaObject) { }
        public DocumentReference Document => CallAsWrapper<DocumentReference>("document");
        public DocumentReference DocumentWithPath(string documentPath) => CallAsWrapper<DocumentReference>("document", documentPath);
        public string ID => Call<string>("getId");
        public string Path => Call<string>("getPath");
        public DocumentReference Parent => CallAsWrapper<DocumentReference>("getParent");
        public ITask<DocumentReference> GetBytes(AndroidJavaObject data) => this.CallAsITask<DocumentReference>("getBytes", data);
 

    }
}