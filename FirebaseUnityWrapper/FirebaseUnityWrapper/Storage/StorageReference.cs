using AndroidUtils;
using GMSTasks;
using UnityEngine;
using FirebaseUnityWrapper.Storage.StorageTask;
using static FirebaseUnityWrapper.Storage.StorageTask.UploadTask;

namespace FirebaseUnityWrapper.Storage
{
    public class StorageReference : JavaObjectWrapper
    {
        public StorageReference(AndroidJavaObject javaObject) : base(javaObject) { }

        public StorageReference Child(string path) => CallAsWrapper<StorageReference>("child", path);

        public StorageReference Parent => CallAsWrapper<StorageReference>("getParent");

        public StorageReference Root => CallAsWrapper<StorageReference>("getRoot");

        public ITask<global::AndroidUtils.Void> Delete() => this.CallAsVoidITask("delete");

        public string Bucket => Call<string>("getBucket");

        public ITask<byte[]> GetBytes(long maxDownloadSizeBytes) => this.CallAsByteArrayITask("getBytes", maxDownloadSizeBytes);

        public string Name => Call<string>("getName");

        public string Path => Call<string>("getPath");

        public ITask<StorageMetadata> Metadata => this.CallAsITask<StorageMetadata>("getMetadata");
        public ITask<StorageMetadata> UpdateMetadata(StorageMetadata metadata) => this.CallAsITask<StorageMetadata>("updateMetadata", metadata);
        public ITask<ListResult> ListAll => this.CallAsITask<ListResult>("listAll");
        public ITask<ListResult> List(int maxResults) => this.CallAsITask<ListResult>("list");

        public ITask<ListResult> ListAfterPageToken(int maxResults, string pageToken) => this.CallAsITask<ListResult>("list", maxResults, pageToken);

        public ITask<TaskSnapshot> PutBytes(byte[] bytes) => this.CallAsITask<TaskSnapshot>("putBytes", bytes);
        public ITask<TaskSnapshot> PutStream(AndroidJavaObject stream) => this.CallAsITask<TaskSnapshot>("putStream", stream);
        public ITask<TaskSnapshot> PutFile(AndroidJavaObject Uri, StorageMetadata storageMetadata) => this.CallAsITask<TaskSnapshot>("putFile", storageMetadata);

    }
}
