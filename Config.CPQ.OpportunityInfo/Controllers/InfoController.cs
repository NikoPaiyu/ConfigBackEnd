using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Config.CPQ.OpportunityInfo.Models;
using Config.CPQ.OpportunityInfo.Services;

namespace Config.CPQ.OpportunityInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly InfoService _detailService;

        public InfoController(InfoService detailService)
        {
            _detailService = detailService;
        }

        [HttpGet]
        public ActionResult<List<Info>> Get() =>
            _detailService.Get();

        [HttpGet("{id:length(24)}", Name = "GetDetail")]
        public ActionResult<Info> Get(string id)
        {
            var detail = _detailService.Get(id);

            if (detail == null)
            {
                return NotFound();
            }

            return detail;
        }

        [HttpPost]
        public ActionResult<Info> Create(Info detail)
        {
            _detailService.Create(detail);

            return CreatedAtRoute("GetDetail", new { id = detail.Id.ToString() }, detail);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Info detailIn)
        {
            var detail = _detailService.Get(id);

            if (detail == null)
            {
                return NotFound();
            }

            _detailService.Update(id, detailIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var detail = _detailService.Get(id);

            if (detail == null)
            {
                return NotFound();
            }

            _detailService.Remove(detail.Id);

            return NoContent();
        }
    }
}
