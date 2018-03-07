using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerWebApiLib.Services;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TimeController : Controller
    {
        [HttpGet("now")]
        public async Task<ActionResult<dynamic>> Get()
        {
            try
            {
                var timeService = new TimeService(new CustomHttpClient());
                var time =  await timeService.GetTime();
                dynamic result = new System.Dynamic.ExpandoObject();
                result.Time = time.CurrentDateTime;
                return new ActionResult<dynamic>(result);
            }
            catch
            {
                return StatusCode(500);
            }


        }
    }
}
