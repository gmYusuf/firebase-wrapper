using UnityEngine;
using AndroidUtils;
using GMSTasks;
using System;
 


namespace FirebaseUnityWrapper.FireStore
{
    public class DocumentReference : JavaObjectWrapper
    {

        public DocumentReference(AndroidJavaObject javaObject) : base(javaObject) { }
        public CollectionReference Collection(string collectionPath) => CallAsWrapper<CollectionReference>("collection", collectionPath);

        public CollectionReference Parent => CallAsWrapper<CollectionReference>("getParent");

        public DocumentReference Root => CallAsWrapper<DocumentReference>("getRoot");

        public FirebaseFirestore Firestore => CallAsWrapper<FirebaseFirestore>("getFirestore");
        
        public ITask<global::AndroidUtils.Void> Delete() => this.CallAsVoidITask("delete");


        public string Name => Call<string>("getName");

        public string ID => Call<string>("getId");
        public ITask<global::AndroidUtils.Void> SetData(AndroidJavaObject data) => this.CallAsVoidITask("set", data);
        public ITask<global::AndroidUtils.Void> UpdateData(String field,AndroidJavaObject data) => this.CallAsVoidITask("set", data, field);


    }
}