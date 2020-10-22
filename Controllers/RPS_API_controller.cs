using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RockPaperScissors_API.Models;


namespace RockPaperScissors_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class rpsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<rpsController> _logger;

        public rpsController(ILogger<rpsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /*
        public rpsController()
        {

        }
        [HttpPost]
        
        public GameResult GetResult(PlayRequest angularPlayRequest)
        {
            GameResult g = new GameResult(angularPlayRequest.PlayerChoice);
            return g;
        } 
        */
    }
    
}
