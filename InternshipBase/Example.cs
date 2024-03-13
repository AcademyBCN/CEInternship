using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using InternshipBase.Helpers;
using Domain;
using Newtonsoft.Json.Linq;
namespace InternshipBase
{
    public class Example
    {

        [FunctionName("Example")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            HttpHelper httpHelper = new HttpHelper();
            var response = await httpHelper.Get(Constants.SwapiBaseUrl + "planets/1/");
            return new OkObjectResult(JObject.Parse(response));
        }
    }
}
