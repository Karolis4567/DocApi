using NSwag;
using System.Text;

namespace DocMvc.Extensions
{
    public static class SbEx
    {
        public static void AddKeyValue(
            this StringBuilder sb
            , string key
            , string value) =>
            sb.AppendLine($"{key}:{value} <br />");

        public static void AddParams(
            this StringBuilder sb, IReadOnlyCollection<OpenApiParameter> param
            )
        {
            foreach (var item in param)
            {
                sb.AddKeyValue("Param:Name", item.Name);
                sb.AddKeyValue("Param:Format", item.Format);
                sb.AddKeyValue("Param:Format", item?.ActualSchema?.Type.ToString());

                foreach (var prop in item?.ActualSchema?.ActualProperties)
                {
                    sb.AppendLine("----------------- <br />");
                    sb.AddKeyValue("Param:ActualProperties:Key", prop.Key);
                    sb.AddKeyValue("Param:ActualProperties:Name", prop.Value.Name);
                    sb.AddKeyValue("Param:ActualProperties:Format", prop.Value.Format);
                    sb.AddKeyValue("Param:ActualProperties:MinLength", prop.Value.MinLength.ToString());
                    sb.AddKeyValue("Param:ActualProperties:MaxLengt", prop.Value.MaxLength.ToString());
                    sb.AddKeyValue("Param:ActualProperties:IsRequired", prop.Value.IsRequired.ToString());
                    sb.AddKeyValue("Param:Count of properties:", prop.Value?.ActualSchema?.ActualProperties?.Count().ToString());
                    sb.AddKeyValue("Param:ActualProperties:DocumentPath", prop.Value?.ActualSchema?.DocumentPath?.ToString());


                    sb.AppendLine("----------------- <br />");
                }


                int stopHere = 1;
            }
        }

        public static void AddResponse(
            this StringBuilder sb, IDictionary<string, OpenApiResponse> dic
            )
        {
            foreach (var item in dic)
            {
                sb.AppendLine("Responses --- <br />");
                sb.AddKeyValue("Response:key:", item.Key);
                sb.AddKeyValue("Response:description:", "");


                if (item.Value?.Schema?.ActualProperties != null)
                {
                    /*
                    foreach (var prop in item.Value?.ExpectedSchemas.ActualProperties)
                    {
                        sb.AppendLine("----------------- <br />");
                        sb.AddKeyValue("Param:ActualProperties:Key", prop.Key);
                        sb.AddKeyValue("Param:ActualProperties:Name", prop.Value.Name);
                        sb.AddKeyValue("Param:ActualProperties:Format", prop.Value.Format);
                        sb.AddKeyValue("Param:ActualProperties:MinLength", prop.Value.MinLength.ToString());
                        sb.AddKeyValue("Param:ActualProperties:MaxLengt", prop.Value.MaxLength.ToString());
                        sb.AddKeyValue("Param:ActualProperties:IsRequired", prop.Value.IsRequired.ToString());
                        sb.AddKeyValue("Param:Count of properties:", prop.Value?.ActualSchema?.ActualProperties?.Count().ToString());
                        sb.AddKeyValue("Param:ActualProperties:DocumentPath", prop.Value?.ActualSchema?.DocumentPath?.ToString());


                        sb.AppendLine("----------------- <br />");
                    }
                    */
                }
                

                sb.AppendLine("End of responses --- <br />");

            }
            int stopHere = 0;
        }

        public static void AddResponseObject(
            this StringBuilder sb, ICollection<OpenApiSchema> apiSchemas
            )
        {
            foreach (var item in apiSchemas)
            { 
              
            }
        }

    }
}
