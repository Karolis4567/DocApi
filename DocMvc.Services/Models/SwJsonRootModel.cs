using DocMvc.Services.Models.SwJsonObjects;

namespace DocMvc.Services.Models
{
    public class SwJsonRootModel
    {
        public string swagger { get; set; }
        public SwJsonInfo info { get; set; }
        public Dictionary<string, SwJsonDefObj> definitions { get; set; }
        public Dictionary<string, Dictionary<string, SwJsonPathObj>> paths { get; set; }
    }

    

   

   

    




}
