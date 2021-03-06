using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionAppThree
{
    public static class FunctionAppThree
    {
        [FunctionName("FunctionAppThree")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "{name}")] HttpRequest req,
            string name)
        {
            Man man = new Man();
            man.name = name;
            return new OkObjectResult(man);
        }
    }

    
}
