using Domain;
using Domain.Models;
using InternshipBase.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace InternshipBase.Functions
{
    public static class ExampleFunction
    {
        [Function("Example")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            HttpHelper httpHelper = new HttpHelper();
            var response = await httpHelper.Get(Constants.SwapiBaseUrl + "planets/1/");
            var seralizedResponse = JsonConvert.DeserializeObject<ExampleResponseModel>(response);
            return new OkObjectResult(seralizedResponse);
        }
    }
}
