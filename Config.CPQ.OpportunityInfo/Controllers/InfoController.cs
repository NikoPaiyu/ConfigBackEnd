/*  OpportunityInfo Controller is used get the opportunity information details.
    url: https://localhost:44321/api/info  */

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
    }
}
