//To get all the data in ConfigPageDb database
//URL: https://localhost:44392/api/config


using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly ConfigService _configService;

        public ConfigController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();

        [HttpGet]
        [Route("{Id}")]
        public ActionResult<Configs> Get(string id)
        {
            var config = _configService.Get(id);

            if (config == null)
            {
                return NotFound();
            }

            return config;
        }
}
        }
