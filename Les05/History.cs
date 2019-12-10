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
    public static class History
    {
        [FunctionName("History")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string from = string.Empty;
            string to = string.Empty;

            foreach (var key in req.Query.Keys)
            {
                if (key == "from")
                {
                    from = req.Query["from"];
                }
                if (key == "to")
                {
                    to = req.Query["to"];
                }
            }//end foreach

            string uitvoer = "van " + from + "aan" + to;
            return new OkObjectResult(uitvoer);
        }
    }
}
