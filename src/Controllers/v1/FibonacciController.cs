using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace fibonacci_csharp.Controllers.v1
{
    [Route("api/v1/[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public IActionResult GetStandardFibonacciSequence()
        {
            var fibSeq = new List<String>();
            for (var i = 0; i < 10; i++)
            {
                fibSeq.Add(Convert.ToString(Maths.Fibonnaci(i)));
            }
            return Ok(fibSeq);
        }

        [HttpGet("{index:int}")]
        public IActionResult GetFibonnaciNumberAtGivenIndexInSequence(int index)
        {
            return Ok(Maths.Fibonnaci(index));
        }

        [HttpGet("/api/v1/Fibonacci/Range")]
        public IActionResult GetFibonnaciSequenceBetweenTwoIndexes([FromQuery] int startIndex, [FromQuery] int endIndex)
        {
            var fibSeq = new List<String>();
            for(var i = startIndex; i < endIndex; i++) 
            {
                fibSeq.Add(Convert.ToString(Maths.Fibonnaci(i)));
            }

            return Ok(fibSeq);
        }
    }
}