using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers.TestController
{
    public class TestController : ApiController
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Get method called");
            return Ok("Test successful");
        }

        [HttpGet("error")]
        public IActionResult GetError()
        {
            throw new Exception("This is a test exception");
        }

        [HttpGet("error-detail")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var activity = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            _logger.LogError($"An error occurred: {activity}");
            return Problem(detail: "An error occurred while processing your request.", statusCode: 500, title: "Internal Server Error");
        }

        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            _logger.LogInformation("Health check successful");
            return Ok(new { status = "Healthy" });
        }
    }
}