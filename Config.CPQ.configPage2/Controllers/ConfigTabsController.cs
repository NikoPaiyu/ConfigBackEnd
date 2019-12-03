/*  ConfigTabs Controller is used to get information about six tabs: Hardware, Accessories, Deployment Service, Configuration Service, BOM, CarePacks.
    url: https://localhost:44315/api/configtabs  */

using System.Collections.Generic;
using Config.CPQ.configPage2.Models;
using Config.CPQ.configPage2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Config.CPQ.configPage2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigTabsController:ControllerBase
    {
        private readonly ConfigTabsService _configTabsService;

        public ConfigTabsController(ConfigTabsService configTabsService)
        {
            _configTabsService = configTabsService;
        }

        [HttpGet]
        public ActionResult<List<ConfigTabs>> Get() =>
            _configTabsService.Get();

        [HttpGet]
        [Route("{config}")]
        public ActionResult<List<ConfigTabs>> Get(string config)
        {
            var configTabs = _configTabsService.Get(config);

            if (configTabs == null)
            {
                return NotFound();
            }

            return configTabs;
        }
    }
}
