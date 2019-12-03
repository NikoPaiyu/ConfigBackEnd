//To display the quote output page by searching through quote number
//URL: https://localhost:44394/api/quoteoutput

using Config.CPQ.QuoteOutput.Models;
using Config.CPQ.QuoteOutput.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Config.CPQ.QuoteOutput.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteOutputController : ControllerBase
    {
        private readonly QuoteOutputService _quoteService;

        public QuoteOutputController(QuoteOutputService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public ActionResult<List<DisplayOption>> Get() =>
            _quoteService.Get();

        [HttpGet]
        [Route("{quoteNumber}")]
        public ActionResult<DisplayOption> Get(string quoteNumber)
        {
            var displayoption = _quoteService.Get(quoteNumber);


            if (displayoption == null)
            {
                return NotFound();
            }

            return displayoption;
        }
    }
}