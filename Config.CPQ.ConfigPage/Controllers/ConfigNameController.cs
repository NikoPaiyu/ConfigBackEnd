//To filter the records by ConfigName
//URL: https://localhost:44392/api/configname/abc15   (for ConfigName abc15)

using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConfigNameController : ControllerBase
    {
        private readonly ConfigService _configService;

        public ConfigNameController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet]
        [Route("{configName}")]
        public ActionResult<List<Configs>> Get(string configname)
        {
            var config = _configService.Getb(configname);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }
    }
}
