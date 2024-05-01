using Newtonsoft.Json;

namespace DocMvc.Services.Extensions.Json
{
    public static class JsonEx
    {
        public static T FromJson<T>(this string json) =>
            JsonConvert.DeserializeObject<T>(json);

        public static string ToJson(this object obj) =>
            JsonConvert.SerializeObject(obj);

        public static T FromJsonNoMeta<T>(this string json) =>
            JsonConvert.DeserializeObject<T>(json,
                new JsonSerializerSettings()
                {
                    MetadataPropertyHandling = MetadataPropertyHandling.Ignore
                });

    }
}
