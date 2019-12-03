/*  PartList Controller is used to add the selected items from each of the tab into new table.
    url: https://localhost:44315/api/partlist  */

using System.Collections.Generic;
using Config.CPQ.configPage2.Models;
using Config.CPQ.configPage2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Config.CPQ.configPage2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartListController : ControllerBase
    {


        private readonly PartService _partService;
        public PartListController(PartService partService)
        {

            _partService = partService;
        }
       
        [HttpGet]
        public ActionResult<List<partlist>> Get() =>
        _partService.Get();

        [HttpPost]
        [Route("{text}")]
        public ActionResult<partlist> Create(string text)
        {
            return _partService.Create(text);
        }
    }
}
