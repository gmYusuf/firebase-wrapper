using AndroidUtils;
using GMSTasks;
using System;
using UnityEngine;

namespace FirebaseUnityWrapper.Storage
{
    public class StorageReference : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public StorageReference(AndroidJavaObject javaObject) : base(javaObject) { }

        public StorageReference Child(string path) => CallAsWrapper<StorageReference>("child", path);

        public StorageReference Parent => CallAsWrapper<StorageReference>("getParent");

        public StorageReference Root => CallAsWrapper<StorageReference>("getRoot");

        public ITask<global::AndroidUtils.Void> Delete() => this.CallAsVoidITask("delete");

        public string Bucket => Call<string>("getBucket");

        public ITask<byte[]> GetBytes(long maxDownloadSizeBytes) => this.CallAsByteArrayITask("getBytes", maxDownloadSizeBytes);

        public string Name => Call<string>("getName");

        public string Path => Call<string>("getPath");
    }
}
