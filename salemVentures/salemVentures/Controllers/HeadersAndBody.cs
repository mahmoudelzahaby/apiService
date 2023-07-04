using Microsoft.AspNetCore.Mvc;

namespace salemVentures.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeadersAndBody : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HeadersAndBody> _logger;

        public HeadersAndBody(ILogger<HeadersAndBody> logger)
        {
            _logger = logger;
        }

        [HttpGet("test")]
        public string test()
        {
            return "ddddddddddd";
        }

        [HttpGet("GetCallHeadersAndBody")]
        public IActionResult GetHeadersAndBody()
        {
            var x = Request.Headers;
            var y = Request.Body;
            return Ok("");
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}