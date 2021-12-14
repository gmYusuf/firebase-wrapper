using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.FireStore
{
    public class Transaction : JavaObjectWrapper
    {
        public Transaction(AndroidJavaObject javaObject) : base(javaObject) { }

        public Transaction Delete(DocumentReference documentRef) => CallAsWrapper<Transaction>("delete", documentRef);
        public Transaction Set(DocumentReference documentRef, AndroidJavaObject value) => CallAsWrapper<Transaction>("set", documentRef, value);
        public Transaction Set(DocumentReference documentRef, string field, AndroidJavaObject value) => CallAsWrapper<Transaction>("set", documentRef, value);
        public DocumentSnapshot Get(DocumentReference documentRef) => CallAsWrapper<DocumentSnapshot>("get", documentRef);

    }
}