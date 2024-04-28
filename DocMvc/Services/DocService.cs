using DocMvc.Extensions;
using DocMvc.Models;
using NSwag;
using System.Text;


namespace DocMvc.Services
{
    public class DocService : IDocService
    {
        // protected HttpClient _httpClient;
        public DocService()
        {
            //this._httpClient = new HttpClient();
        }

        /*
        public async Task<string> GetWebContent(string link)
        {
            string ret = null;
            var response = await this._httpClient.GetAsync(link);
            if (response.IsSuccessStatusCode)
            {
                ret = response.Content.ReadAsStringAsync().Result;
            }
            return ret;
        }
        */

        private async Task<OpenApiDocument> GetOpenApiDocument(string link) =>
            await OpenApiDocument.FromUrlAsync(link);


        public async Task<DocModel> GetDoc(string link)
        {
            var document = await this.GetOpenApiDocument(link);
            var html = new StringBuilder();

            html.AddKeyValue("Info", document.Info.Title);
            html.AddKeyValue("Description", document.Info.Description);
            
            foreach (var item in document.Responses)
            {
                html.AddKeyValue("Response:key", item.Key);
            }


            foreach (var path in document.Paths)
            {
                
                html.AddKeyValue("Method", $"<b>{path.Key}</b>");

                foreach (var pathValue in path.Value.Values)
                {
                    //html.AddKeyValue("Summary", pathValue.Summary);
                    //html.AddKeyValue("Description", pathValue.Description);
                    //html.AppendLine("Actual params <br />");
                    //html.AddParams(pathValue.ActualParameters);
                    html.AddResponse(pathValue.Responses);


                   //  html.AddResponseObject(pathValue.ActualSchemes);
                    // html.AppendLine("Params <br />");
                    // html.AddParams(pathValue.Parameters.ToArray());

                }         
               
            }

            var model = new DocModel();
            model.link = html.ToString();

            return model;
        }
    }
}
