using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //弃用设置deprecated=true
    [ApiVersion("1.0",Deprecated =true)]
    //路由设置版本号
    [Route("api/{v:apiVersion}/values")]
    [ApiController]
    public class ValuesV1Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "value1 from Version 1","value2 from Version 1"
            };
        }
    }

}