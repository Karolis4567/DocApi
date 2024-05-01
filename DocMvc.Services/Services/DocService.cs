using DocMvc.Services.Extensions.Json;
using DocMvc.Services.Models;

namespace DocMvc.Services.Services
{
    public class DocService : IDocService
    {
        public async Task<SwJsonDataModel> GetSwJsonData(string json)
        {
            var swJsonRootModel = json.FromJsonNoMeta<SwJsonRootModel>();
            
            var ret = new SwJsonDataModel();
            ret.swagger = swJsonRootModel.swagger;
            ret.title = swJsonRootModel.info.title;
            ret.version = swJsonRootModel.info.version;
            
            ret.objectNames = swJsonRootModel
                .definitions
                .Select(x => x.Key)
                .OrderBy(x => x)
                .ToArray();

            ret.controllerNames = swJsonRootModel
                .paths
                .Select(x => x.Key)
                .OrderBy(x => x)
                .ToArray();
            


            return ret;
        }

    }
}
