using Config.CPQ.QuoteOutput.Models;
using Config.CPQ.QuoteOutput.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Config.CPQ.QuoteOutput.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayOptionsController : ControllerBase
    {
        private readonly QuoteOutputService _quoteService;

        public DisplayOptionsController(QuoteOutputService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public ActionResult<List<DisplayOption>> Get() =>
            _quoteService.Get();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<DisplayOption> Get(string id)
        {
            var displayoption = _quoteService.Get(id);

            if (displayoption == null)
            {
                return NotFound();
            }

            return displayoption;
        }

        [HttpPost]
        public ActionResult<DisplayOption> Create(DisplayOption displayoption)
        {
            _quoteService.Create(displayoption);

            return CreatedAtRoute("GetDisplay", new { id = displayoption.Id.ToString() }, displayoption);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, DisplayOption displayoptionIn)
        {
            var displayoption = _quoteService.Get(id);

            if (displayoption == null)
            {
                return NotFound();
            }

            _quoteService.Update(id, displayoptionIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var displayoption = _quoteService.Get(id);

            if (displayoption == null)
            {
                return NotFound();
            }

            _quoteService.Remove(displayoption.Id);

            return NoContent();
        }
    }
}