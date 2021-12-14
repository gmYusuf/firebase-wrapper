using UnityEngine;
using System.Collections;
using AndroidUtils;

namespace FirebaseUnityWrapper.Storage
{
    public class StorageMetadata : JavaObjectWrapper
    {
        public StorageMetadata(AndroidJavaObject javaObject) : base(javaObject) { }
        public StorageMetadata() : base("com.google.firebase.storage.StorageMetadata") { }
        public string Bucket => Call<string>("getBucket");
        public long CreationTimeMillis => Call<long>("getCreationTimeMillis");
        public string CustomMetadata(string key) => Call<string>("getCustomMetadata",key);

        public string Name => Call<string>("getName");
        public string Path => Call<string>("getPath");

        public long UpdateTimeMillis => Call<long>("getUpdateTimeMillis");

        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.google.firebase.storage.StorageMetadatar$Builder") { }
            public StorageMetadata Build() => CallAsWrapper<StorageMetadata>("build");
            public string CacheControl => Call<string>("getCacheControl");
            public string ContentDisposition => Call<string>("getContentDisposition");
            public string ContentEncoding => Call<string>("getContentEncoding");
            public string ContentLanguage => Call<string>("getContentLanguage");
            public string ContentType => Call<string>("getContentType");
            public Builder SetCacheControl(string cacheControl) => CallAsWrapper<Builder>("setCacheControl", cacheControl);
            public Builder SetContentDisposition(string contentDisposition) => CallAsWrapper<Builder>("setContentDisposition", contentDisposition);
            public Builder SetContentEncoding(string contentEncoding) => CallAsWrapper<Builder>("setContentEncoding", contentEncoding);
            public Builder SetContentLanguage(string contentLanguage) => CallAsWrapper<Builder>("setContentLanguage", contentLanguage);
            public Builder SetContentType(string contentType) => CallAsWrapper<Builder>("setContentType", contentType);
            public Builder SetCustomMetadata(string key, string value) => CallAsWrapper<Builder>("setCustomMetadata", key,value);

        }

    }
}