using UnityEngine;
using System.Collections;
using AndroidUtils;
using FirebaseUnityWrapper.Firebase;
using GMSTasks;

namespace FirebaseUnityWrapper.FireStore
{
    public class FirebaseFirestore : JavaObjectWrapper
    {
        public FirebaseFirestore(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.firebase.firestore.FirebaseFirestore");

        public static FirebaseFirestore Instance => androidJavaClass.CallStaticAsWrapper<FirebaseFirestore>("getInstance");
        public static FirebaseFirestore GetInstance(FirebaseApp app) => androidJavaClass.CallStaticAsWrapper<FirebaseFirestore>("getInstance", app);
        public FirebaseApp Reference => CallAsWrapper<FirebaseApp>("getApp");

        public CollectionReference Collection(string collectionPath) => CallAsWrapper<CollectionReference>("collection", collectionPath);

        public static void LoggingEnabled(bool loggingEnabled) => androidJavaClass.CallStatic("setLoggingEnabled", loggingEnabled);
        

        public ITask<global::AndroidUtils.Void> Terminate => this.CallAsVoidITask("terminate");

        public void UseEmulator(string host, int port) => Call("useEmulator", host, port);
        public ITask<global::AndroidUtils.Void> WaitForPendingWrites => this.CallAsVoidITask("waitForPendingWrites");

    }
}