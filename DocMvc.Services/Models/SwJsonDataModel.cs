using System.Text;

namespace DocMvc.Services.Models
{
    public class SwJsonDataModel
    {
        public SwJsonDataModel()
        {

        }

        public string swagger { get; set; }
        public string title { get; set; }
        public string version { get; set; }

        public string[] objectNames { get; set; }
        public string[] controllerNames { get; set; }
        

    }
}
