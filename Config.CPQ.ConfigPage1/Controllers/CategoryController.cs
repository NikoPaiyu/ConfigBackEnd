//To filter the records by category
//URL: https://localhost:44392/api/category/PointOfSales (for PointOfSales category)

using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ConfigService _configService;

        public CategoryController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet]
        [Route("{Category}")]
        public ActionResult<List<Configs>> Get(string category)
        {
            var config = _configService.Gete(category);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }
    }
}
