using DocMvc.Services.Models;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace DocMvc.Models
{
    public class DocModel
    {
        protected SwJsonDataModel _model;
        public DocModel(SwJsonDataModel model)
        {
            this._model = model;
        }

        public string title => this._model.title;
        public string swagger => this._model.swagger;
        public string version => this._model.version;
        public string[] controllerNames => this._model.controllerNames;
        public string[] objectNames => this._model.objectNames;
        
    }
}
