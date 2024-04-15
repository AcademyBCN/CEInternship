using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace InternshipBase.Functions
{
    public static class FilmFunction
    {
        [Function("FilmFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Film Function was called.");

            ///////////////////////////////////
            /// PLEASE START YOUR CODE HERE ///
            ///////////////////////////////////

            var result = "This needs to be changed";

            return new OkObjectResult(result);
        }
    }
}
