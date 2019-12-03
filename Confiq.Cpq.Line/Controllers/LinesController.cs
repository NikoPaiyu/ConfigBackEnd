/*Lines Controller is used to insert anew line item and update it.
 url: https://localhost:44381/api/lines */

using Confiq.Cpq.Line.Models;
using Confiq.Cpq.Line.Services;
using Microsoft.AspNetCore.Mvc;

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
             public string Getheader() =>
            
           _lineService.SampleJSONSerilaize();

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
            [Route("{quoteNumber}/{prtid}")]
            public ActionResult<Lines> Create(string quotenumber,string prtid)
            {
                return   _lineService.CreateLine(quotenumber,prtid);
            
          
            }

        [HttpPost]
       
        public string Update(string Id, Lines line)
        {

            _lineService.Update(line.Id, line);

            return _lineService.SampleJSONSerilaize();
        }

      


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

