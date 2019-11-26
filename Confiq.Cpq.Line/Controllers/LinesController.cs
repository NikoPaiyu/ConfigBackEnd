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
    public class LinesController : ControllerBase
    {
            private readonly LineService _lineService;

            public LinesController(LineService lineService)
            {
                _lineService = lineService;
            }

            [HttpGet]

            public ActionResult<List<Lines>> Get() =>
                _lineService.Get();

            [HttpGet]
            [Route("{Id}")]

        public ActionResult<Lines> Get(string id)
            {
                var line = _lineService.Get(id);

                if (line == null)
                {
                    return NotFound();
                }

                return line;
            }

            [HttpPost]
            public ActionResult<Lines> Create(Lines line)
            {
                _lineService.Create(line);
            
                return CreatedAtRoute("GetLine", new { id = line.Id.ToString() }, line);
            }

        [HttpPost]
        [Route("{Id}")]
        public ActionResult<Lines> Update(Lines line)
        {
            // _lineService.Create(line);
           // Console.WriteLine("Qty -->");
            _lineService.Update(line.Id, line);

            // return CreatedAtRoute("GetLine", new { id = line.Id.ToString() }, line);
            return line;
        }

        //[HttpPut]
        //[Route("{quoteNumber}/{partNumber}/{Quantity}/{restDisc}/{restType}")]

        //public IActionResult Update(string quotenumber, string partnumber, int quantity, double restdisc, float resttype)
        //{
        //    var line = _lineService.Get(quotenumber, partnumber);

        //    if (line == null)
        //    {
        //        return NotFound();
        //    }
        //    if (line.Quantity != quantity)
        //    {
        //        line.Quantity = quantity;
        //        _lineService.Update(line.Id, line);
        //    }
        //    if (line.restDisc != restdisc)
        //    {
        //        line.restDisc = restdisc;
        //        _lineService.Update(line.Id, line);
        //    }
        //    if (line.restType != resttype)
        //    {
        //        line.restType = resttype;
        //        _lineService.Update(line.Id, line);
        //    }
        //        return NoContent();
        //}

        //[HttpPut]
        //[Route("{quoteNumber}/{partNumber}/{restDisc}")]

        //public IActionResult Update(string quotenumber, string partnumber, double restdisc)
        //{
        //    var line = _lineService.Get(quotenumber, partnumber);

        //    if (line == null)
        //    {
        //        return NotFound();
        //    }
           
        //    if (line.restDisc != restdisc)
        //    {
        //        line.restDisc = restdisc;
        //        _lineService.Update(line.Id, line);
        //    }
            
        //    return NoContent();
        //}


        //[HttpPut]
        //[Route("{quoteNumber}/{partNumber}/{restType}")]

        //public IActionResult Update(string quotenumber, string partnumber, float resttype)
        //{
        //    var line = _lineService.Get(quotenumber, partnumber);

        //    if (line == null)
        //    {
        //        return NotFound();
        //    }

        //    if (line.restType != resttype)
        //    {
        //        line.restType = resttype;
        //        _lineService.Update(line.Id, line);
        //    }
        //    return NoContent();
        //}

        [HttpDelete]
        [Route("{Id}")]
        public IActionResult Delete(string id)
        {
            var line = _lineService.Get(id);

            if (line == null)
            {
                return NotFound();
            }

            _lineService.Remove(line);

            return NoContent();
        }
        
        }



    }

