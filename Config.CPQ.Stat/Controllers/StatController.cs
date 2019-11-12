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

        [HttpPost]
        public ActionResult<Stat1> Create(Stat1 stat1)
        {
            _stat1Services.Create(stat1);

            return CreatedAtRoute("GetQuote", new { id = stat1.Id.ToString() }, stat1);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Stat1 stat1In)
        {
            var stat1 = _stat1Services.Get(id);

            if (stat1 == null)
            {
                return NotFound();
            }

            _stat1Services.Update(id, stat1In);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var stat1 = _stat1Services.Get(id);

            if (stat1 == null)
            {
                return NotFound();
            }

            _stat1Services.Remove(stat1.Id);

            return NoContent();
        }
    }
}
