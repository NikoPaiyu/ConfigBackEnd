using Confiq.Cpq.Line.Models;
using Confiq.Cpq.Line.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confiq.Cpq.Line.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscAmtController : ControllerBase
    {
        private readonly LineService _lineService;
        public DiscAmtController(LineService lineService)
        {
            _lineService = lineService;
        }

        [HttpPost]
        [Route("{Id}")]
        public Lines Update(string Id, Lines line)
        {

            _lineService.UpdateDiscAmt(line.Id, line);
            return line;
        }
    }
}
