using DocMvc.Services.Models;

namespace DocMvc.Services.Services
{
    public interface IDocService
    {
        Task<SwJsonDataModel> GetSwJsonData(string json);
    }
}
