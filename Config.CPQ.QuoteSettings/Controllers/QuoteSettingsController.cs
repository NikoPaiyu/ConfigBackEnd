using System.Collections.Generic;
using Config.CPQ.QuoteSettings.Models;
using Config.CPQ.QuoteSettings.Services;
using Microsoft.AspNetCore.Mvc;


namespace Config.CPQ.QuoteSettings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteSettingsController : ControllerBase
    {
        private readonly QuoteServices _quoteServices;

        public QuoteSettingsController(QuoteServices quoteServices)
        {
            _quoteServices = quoteServices;
        }

        [HttpGet]
        public ActionResult<List<Quote>> Get() =>
            _quoteServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetQuote")]
        public ActionResult<Quote> Get(string id)
        {
            var quote = _quoteServices.Get(id);

            if (quote == null)
            {
                return NotFound();
            }

            return quote;
        }

        [HttpPost]
        public ActionResult<Quote> Create(Quote quote)
        {
            _quoteServices.Create(quote);

            return CreatedAtRoute("GetQuote", new { id = quote.Id.ToString() }, quote);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Quote quoteIn)
        {
            var quote = _quoteServices.Get(id);

            if (quote == null)
            {
                return NotFound();
            }

            _quoteServices.Update(id, quoteIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var quote = _quoteServices.Get(id);

            if (quote == null)
            {
                return NotFound();
            }

            _quoteServices.Remove(quote.Id);

            return NoContent();
        }
    }
}
