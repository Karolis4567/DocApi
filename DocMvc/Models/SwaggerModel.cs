using NJsonSchema.Generation.TypeMappers;
using System.Runtime.Remoting;

namespace DocMvc.Models
{
    public class SwaggerModel
    {
        public string openapi { get; set; }
        public SwaggerInfo Info { get; set; }
        public Dictionary<string, Dictionary<string, SwaggerControllersPath>> paths { get; set; }
    }


    public class SwaggerInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }

    public class SwaggerResponse
    {
        public string Description { get; set; }
    }
    public class SwaggerControllersPaths
    {
       
    }
    public class SwaggerControllersPath
    {
        public List<string> Tags { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Dictionary<string, Response> Responses { get; set; }

        public object? RequestBody { get; set; }
    }

    public class Response
    {
        public string Description { get; set; }
    }
    public class Content1
    {
        public Dictionary<string, ContentContentContent>? Content { get; set; }
    }

    public class ContentContent
    { 
        public ContentContentContent Schema { get; set; }
    }
    public class ContentContentContent
    {
        public string Type { get; set; }
        public ContentContentContentItems Items { get; set; }
    }

    public class ContentContentContentItems
    { 
        public string Type { get; set; } 
        public string Format { get; set; }
    }

}
