//To filter the records by ConfigId
//URL: https://localhost:44392/api/configid/ab12   (for ConfigID ab12)

using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConfigIDController : ControllerBase
    {
        private readonly ConfigService _configService;

        public ConfigIDController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet("{id:length(5)}")]
        [Route("{configId}")]
        public ActionResult<List<Configs>> Get(string configid)
        {
            var config = _configService.Geta(configid);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }
    }
}
