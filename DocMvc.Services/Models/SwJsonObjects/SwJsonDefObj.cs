namespace DocMvc.Services.Models.SwJsonObjects
{
    public class SwJsonDefObj
    {
        public string type { get; set; }
        public IDictionary<string, SwJsonDefObjProp> properties { get; set; }
    }

    public class SwJsonDefObjProp : BaseTypeRef
    {
        public string format { get; set; }
    }
}
