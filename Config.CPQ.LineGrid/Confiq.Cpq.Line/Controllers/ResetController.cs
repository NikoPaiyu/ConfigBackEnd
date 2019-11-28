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

            //if (line == null)
            //{
            //    return NotFound();
            //}
            //return line;

           return _lineService.Get();
        }

        //[HttpPost]
        //public ActionResult<Lines> Create(Lines line)
        //{
        //    _lineService.Create(line);

        //    return CreatedAtRoute("GetLine", new { id = line.Id.ToString() }, line);
        //}

        //[HttpPost]
        //[Route("{quoteNumber}")]
        //public ActionResult<Lines> Update(Lines line)
        //{

        //    _lineService.UpdateA(line.quoteNumber, line);
        //    return line;
        //}

        //[HttpPost]
        //[Route("{Id}")]

        //public ActionResult<Lines> UpdateMany(Lines line)
        //{
        //    var updmanyresult = await collection.UpdateManyAsync(
        //Lines<BsonDocument>.Filter.Gt("MasterID", 100),
        //                        Builders<BsonDocument>.Update.Inc("MasterID", 10))
        //}


        //[HttpDelete]
        //[Route("{Id}")]
        //public IActionResult Delete(string id)
        //{
        //    var line = _lineService.Get(id);

        //    if (line == null)
        //    {
        //        return NotFound();
        //    }

        //    _lineService.Remove(line);

        //    return NoContent();
        //}

    }
}




