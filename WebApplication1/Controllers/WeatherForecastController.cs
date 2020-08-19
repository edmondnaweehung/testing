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
		public List<string> Get()
		{
<<<<<<< HEAD
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Summary = Summaries[rng.Next(Summaries.Length)]
			})
			.ToArray();
=======
			return new List<string> {
				"Hello World",
				"Web Api"
			};
>>>>>>> dc47b598e9a24c7d726d09352697f7b4e0dbc40c
		}
	}
}
