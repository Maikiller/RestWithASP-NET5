using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonCalculatorController : ControllerBase
    {
        private readonly ILogger<PersonCalculatorController> _logger;

        public PersonCalculatorController(ILogger<PersonCalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            return BadRequest("Invalid Input");
        }
    }
}