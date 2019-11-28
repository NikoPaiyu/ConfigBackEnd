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
    public class DiscPercentController : ControllerBase
    {
        private readonly LineService _lineService;
        public DiscPercentController(LineService lineService)
        {
            _lineService = lineService;
        }


        [HttpPost]
        [Route("{Id}")]
        //public string Update(Lines line)
        //{
        //    return "Quantity" + line.Quantity + " product " + line.Id;
        //}
        public Lines Update(string Id, Lines line)
        {

            _lineService.UpdateDisc(line.Id, line);
            return line;
        }
    }
}
