using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Database
{
    public class DataSnapshot : JavaObjectWrapper
    { 
        public DataSnapshot(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool Contains(string field) => Call<bool>("contains", field);
        public bool Exists => Call<bool>("exists");
        public string Key => Call<string>("getKey");
        public bool Child => Call<bool>("hasChild");
        public bool Children(string field) => Call<bool>("hasChildren", field);

        public string GetValue()
        { 
            return Call<AndroidJavaObject>("getValue").ToString();
        }
    }
}