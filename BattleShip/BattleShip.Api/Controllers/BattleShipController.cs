using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShip.Api.Controllers
{
    /// <summary>
    /// BattleShipController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BattleShipController : ControllerBase
    {
        private ILogger _logger;
        private IBoard _board;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="logger"></param>
        public BattleShipController(IBoard board, ILogger<BattleShipController> logger)
        {
            _board = board;
            _logger = logger;
        }

        
        /// <summary>
        /// Position format is like A6
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        [HttpPost("attack")]
        public IActionResult  Attack(string position)
        {
            try
            {
               var result =  _board.Attack(position);

                return Ok(result?Constants.Hit:Constants.Miss);

            }catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }


        /// <summary>
        /// To check the api is up and running 
        /// </summary>
        /// <returns></returns>
        [HttpGet("healthcheck")]
        public IActionResult healthcheck()
        {
            try
            {
                return Ok("api is up and running");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }
    }
}
