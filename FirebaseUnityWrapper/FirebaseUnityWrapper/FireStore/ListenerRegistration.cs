using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.FireStore
{
    public class ListenerRegistration : JavaObjectWrapper
    {

        public ListenerRegistration(AndroidJavaObject javaObject) : base(javaObject) { }
        public void Remove() => Call("remove");

    }
}