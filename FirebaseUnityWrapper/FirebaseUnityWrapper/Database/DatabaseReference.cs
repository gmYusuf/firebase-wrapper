using UnityEngine;
using System.Collections;
using AndroidUtils;
using GMSTasks;
using System;
using FirebaseUnityWrapper.Database.Event;

namespace FirebaseUnityWrapper.Database
{
    public class DatabaseReference : JavaObjectWrapper
    {
        public DatabaseReference(AndroidJavaObject javaObject) : base(javaObject) { }

        public DatabaseReference Child(string path) => CallAsWrapper<DatabaseReference>("child", path);

        public DatabaseReference Parent => CallAsWrapper<DatabaseReference>("getParent");

        public DatabaseReference Root => CallAsWrapper<DatabaseReference>("getRoot");

        public ITask<global::AndroidUtils.Void> GoOffline => this.CallAsVoidITask("goOffline");
        public ITask<global::AndroidUtils.Void> GoOnline => this.CallAsVoidITask("goOnline");
        public string Key => Call<string>("getKey");
        /*  public IEvent<DataSnapshot> AddValueEventListener(Action<DataSnapshot> valueEventListener)
          {
              return this.CallAsIEvent<DataSnapshot>("addValueEventListener", valueEventListener);

          }*/
        public ValueEventListener AddValueEventListener(Action<DataSnapshot> valueEventListener)
        { 

            ValueEventListenerWrapper valueEventListenerWrapper = new ValueEventListenerWrapper();
           return CallAsWrapper<ValueEventListener>("addValueEventListener", valueEventListener);

            //return this.CallAsIEvent<DataSnapshot>("addValueEventListener", valueEventListener);

        }

        public ITask<global::AndroidUtils.Void> SetValue(string value) => this.CallAsVoidITask("setValue", value);

        public ITask<global::AndroidUtils.Void> SetValue(string value, string priority) => this.CallAsVoidITask("setValue", value,priority);



    }

    internal class ValueEventListenerWrapper  
    { 
    }
}