using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerIDController : ControllerBase
    {
        private readonly ConfigService _configService;

        public CustomerIDController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet]
        [Route("{CustomerId}")]
        public ActionResult<List<Configs>> Get(string customerid)
        {
            var config = _configService.Getd(customerid);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }
    }
}
