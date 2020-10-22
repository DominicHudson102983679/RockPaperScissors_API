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
        public rpsController()
        {

        }
        [HttpPost]
        
        public GameResult GetResult(PlayRequest angularPlayRequest)
        {
            GameResult g = new GameResult(angularPlayRequest.PlayerChoice);
            return g;
        } 
        
    }
    
}
