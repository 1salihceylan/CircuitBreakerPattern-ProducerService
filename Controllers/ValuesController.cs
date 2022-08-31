using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProducerService.Controllers
{
    [Route("api/producer")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("error")]
        public ActionResult<IEnumerable<string>> Error()
        {
            throw new Exception("There is an Error");
        }

        [HttpGet("timeout")]
        public ActionResult<IEnumerable<string>> TimeOut()
        {
            return StatusCode(408);
        }

        [HttpGet("success")]
        public ActionResult<IEnumerable<string>> Success()
        {
            return Ok("Transaction is Successfull");
        }
    }
}
