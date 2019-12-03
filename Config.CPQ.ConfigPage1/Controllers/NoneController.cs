//To filter by either category,configId, configName, customerId or email
//URL: https://localhost:44392/api/none/abcd7@email.com  (returns the record which contains abcd7@email.com)
//URL: https://localhost:44392/api/none/ab14  (returns the record which contains ab14)

using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NoneController : ControllerBase
    {
        private readonly ConfigService _configService;

        public NoneController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet]
        [Route("{searchText}")]
        public ActionResult<List<Configs>> Get(string searchText)
        {
            var config = _configService.GetConfigList(searchText);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }


       
    }
}

