using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [Route("api/[controller]")]
    public class MathController : Controller
    {
        [HttpGet("add")]
        public ActionResult<dynamic> Add(decimal n1, decimal n2)
        {
            try
            {
                var sum = DockerWebApiLib.Services.MathService.Add(n1, n2);
                dynamic result = new System.Dynamic.ExpandoObject();
                result.Sum = sum;
                return new ActionResult<dynamic>(result);
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpPost("add")]
        public ActionResult Post([FromBody] decimal[] parameters)
        {
            try
            {
                if (parameters== null || parameters.Length != 2)
                {
                    return BadRequest("Request must have 2 valid numerics");
                }
                decimal param1 = parameters[0];
                decimal param2 = parameters[1];
                var sum =  DockerWebApiLib.Services.MathService.Add(param1, param2);
                dynamic result = new System.Dynamic.ExpandoObject();
                result.Sum = sum;
                //Todo: Verify the sum is NOT to be returned
                return StatusCode(200);
            }
            catch 
            {
                return StatusCode(500);
            }
} 


    }
}
