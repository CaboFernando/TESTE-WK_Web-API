using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using Web_Application.Models;

namespace Web_Application.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            string ApiBaseUrl = "https://localhost:7057/api/";
            string MetodoPath = "Produtos/3";

            var model = new ProdutosViewModel();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var retorno = JsonConvert.DeserializeObject<ProdutosViewModel>(streamReader.ReadToEnd());

                    if (retorno != null)
                        model = retorno;
                }

            }
            catch (Exception e)
            {

                throw e;
            }

            return View(model);
        }
    }
}
