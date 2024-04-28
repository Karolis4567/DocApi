using DocMvc.Models;
using DocMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocMvc.Controllers
{
    public class DocController : Controller
    {
        protected IDocService _service;
        public DocController(IDocService docService) 
        {
            this._service = docService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Doc(string link)
        {
            var model = await this._service.GetDoc(link);
            return View(model);
        }

    }
}
