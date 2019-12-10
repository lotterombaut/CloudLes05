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
    public static class Deling
    {
        [FunctionName("Deling")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "deling/{getal1}/{getal2}")] HttpRequest req, double getal1, double getal2,
            ILogger log)
        {
            if (getal2 != 0)
            {
                return new OkObjectResult(getal1 / getal2);
            }
            else
            {
                dynamic code = new StatusCodeResult(400);
                string melding = "Je kan niet delen door nul!";
                return code + "," + melding;
            }
        }
    }
}
