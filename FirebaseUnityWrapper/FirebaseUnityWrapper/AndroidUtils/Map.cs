using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.AndroidUtils
{
    public class Map<T1, T2> : JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.util.Map";

        public Map(AndroidJavaObject javaObject) : base(javaObject) { }

        public Map() : base(CLASS_NAME) { }

        public Map(string arg1, string arg2) : base(CLASS_NAME, arg1, arg2) { }
    }
}