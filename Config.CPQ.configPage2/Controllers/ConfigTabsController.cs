using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
