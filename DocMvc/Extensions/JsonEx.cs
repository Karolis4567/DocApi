using Newtonsoft.Json;

namespace DocMvc.Extensions
{
    public static class JsonEx
    {
        public static string ToJson(this object obj) =>
            JsonConvert.SerializeObject(obj);

        public static T FromJson<T>(this string json) =>
           JsonConvert.DeserializeObject<T>(json);

    }
}
