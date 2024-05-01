using Newtonsoft.Json;

namespace DocMvc.Services.Models.SwJsonObjects
{
    public class SwJsonPathObj : BaseSumDescObj
    {
        public string[] tags { get; set; }
        public Dictionary<string, SwJsonPathObjResponse> responses { get; set; }
        public SwJsonPathObjParams[] parameters { get; set; }
    }

    public class SwJsonPathObjParams : BaseType
    {
        [JsonProperty("in")]
        public string _in { get; set; }
        public string name { get; set; }
        public string format { get; set; }
        public SwJsonPathObjParamsSchema schema { get; set; }
    }

    public class SwJsonPathObjResponse
    {
        public string description { get; set; }
    }

    public class SwJsonPathObjParamsSchema : BaseTypeRef
    {
        public SwJsonDefObjProp items { get; set; }
    }
}
