using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<WeatherForecast> Get()
        {
            List<string> Summaries = new List<string> {
                "AUUH",
                "asdasdasd",
                "dfgdfgdfg",
                "56hfhgfghf"
            };
            return Summaries.Select(c => new WeatherForecast
            {
                Summary = c
            }).ToList();
        }
    }
}
