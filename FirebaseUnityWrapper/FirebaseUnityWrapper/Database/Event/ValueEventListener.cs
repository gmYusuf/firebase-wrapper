using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database.Event
{
    public class ValueEventListener : JavaObjectWrapper
    {
        public ValueEventListener(AndroidJavaObject javaObject) : base(javaObject) { }
        //  com/google/firebase/database/ValueEventListener
        // public ValueEventListener(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}