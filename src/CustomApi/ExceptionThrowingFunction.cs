using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace CustomApi
{
    public static class ExceptionThrowingFunction
    {
        [FunctionName("ExceptionThrowingFunction")]
        public static IActionResult RunGetException(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "exception")]
            HttpRequest request)
        {
            throw new InvalidOperationException("The only goal of this function is to throw an Exception.");
        }
    }
}
