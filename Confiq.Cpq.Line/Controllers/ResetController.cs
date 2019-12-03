/* Reset Controller is used to reset the discount feild of all the lines to zero.
 * url: https://localhost:44381/api/reset  */


using Confiq.Cpq.Line.Models;
using Confiq.Cpq.Line.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Confiq.Cpq.Line.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResetController : ControllerBase
    {
        private readonly LineService _lineService;

        public ResetController(LineService lineService)
        {
            _lineService = lineService;
        }

        [HttpGet]

        public ActionResult<List<Lines>> Get() =>
            _lineService.Get();

        [HttpGet]
        [Route("{quoteNumber}")]

        public ActionResult<List<Lines>> Get(string quotenumber)
        {
            _lineService.UpdateA(quotenumber);

           return _lineService.Get();
        }

    }
}




