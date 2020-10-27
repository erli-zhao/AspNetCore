using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        public IActionResult GetBaseInof()
        {
            HttpClient client = new HttpClient();
            return  new ContentResult();
        }

        void MethodA([In][Out] ref double x)
        {

        }
    }


}