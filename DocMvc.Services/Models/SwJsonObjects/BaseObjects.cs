using Newtonsoft.Json;

namespace DocMvc.Services.Models.SwJsonObjects
{
    public class BaseSumDescObj
    {
        public string summary { get; set; }
        public string description { get; set; }
    }

    public class BaseType
    {
        public string type { get; set; }
    }

    public class BaseTypeRef : BaseType
    {
        [JsonProperty("$ref")]
        public string r { get; set; }
    }
}