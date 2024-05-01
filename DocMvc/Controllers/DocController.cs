using DocMvc.Models;
using DocMvc.Services.Services;
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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Doc([FromForm] DocParametersModel param)
        {
            var swJsonData = await this._service.GetSwJsonData(param.json);
            var model = new DocModel(swJsonData);
            return View(model);
        }       

    }
}
