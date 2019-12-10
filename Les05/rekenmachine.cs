using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Les05
{
    public static class rekenmachine
    {
        [FunctionName("rekenmachine")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "som/{getal1}/{getal2}")] HttpRequest req, int getal1, int getal2,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            return new OkObjectResult(getal1 + getal2);
            //StatusCodeResult is voor de statuscode
            //okresult geeft statuscode van 200
            //OkObjectresult de meegegeven parameters steekt hij in de body
                        
        }
    }
}
