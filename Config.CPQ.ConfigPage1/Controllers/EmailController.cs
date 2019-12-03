//To filter the records by email
//URL: https://localhost:44392/api/email/abcd4@email.com  (for email abcd4@email.com)

using Config.CPQ.ConfigPage.Models;
using Config.CPQ.ConfigPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Config.CPQ.ConfigPage.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly ConfigService _configService;

        public EmailController(ConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet]
        public ActionResult<List<Configs>> Get() =>
            _configService.Get();


        [HttpGet]
        [Route("{createdByEmail}")]
        public ActionResult<List<Configs>> Get(string createdbyemail)
        {
            var config = _configService.Getc(createdbyemail);

            if (config == null)
            {
                return NotFound();
            }
            return config;
        }
    }
}

