using DocMvc.Models;

namespace DocMvc.Services
{
    public interface IDocService
    {
        Task<DocModel> GetDoc(string link);
    }
}
