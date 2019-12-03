/*This controller is a header page
 URL:   https://localhost:44357/api/stat */

using System.Collections.Generic;
using Config.CPQ.Static.Models;

using Microsoft.AspNetCore.Mvc;


namespace Config.CPQ.Static.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        private readonly StatServices _stat1Services;

        public StatController(StatServices stat1Services)
        {
            _stat1Services = stat1Services;
        }

        [HttpGet]
        public ActionResult<List<Stat1>> Get() =>
            _stat1Services.Get();

        [HttpGet("{id:length(24)}", Name = "GetStat1")]
        public ActionResult<Stat1> Get(string id)
        {
            var stat1 = _stat1Services.Get(id);

            if (stat1 == null)
            {
                return NotFound();
            }

            return stat1;
        }
    }
}
