using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiVersionNeutral]
    [Route("api/a")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Good";
        }
    }
}