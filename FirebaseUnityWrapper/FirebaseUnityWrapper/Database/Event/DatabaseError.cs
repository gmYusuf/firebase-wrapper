using AndroidUtils;
using UnityEngine;

namespace FirebaseUnityWrapper.Database.Event
{
    public class DatabaseError : JavaObjectWrapper
    {

        public DatabaseError(AndroidJavaObject javaObject) : base(javaObject) { }
        public int Code => Call<int>("getCode");
        public string Details => Call<string>("getDetails");
        public string Message => Call<string>("getMessage");

    
    }
}