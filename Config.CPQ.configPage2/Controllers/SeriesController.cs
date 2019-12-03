/*  Series Controller is used to get list of series for each of the selected category.
    url: https://localhost/44315/api/series  */

using System.Collections.Generic;
using Config.CPQ.configPage2.Models;
using Config.CPQ.configPage2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Config.CPQ.configPage2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private readonly SeriesService _seriesService;

        public SeriesController(SeriesService seriesService)
        {
            _seriesService = seriesService;
        }

        [HttpGet]
        public ActionResult<List<Series>> Get() =>
            _seriesService.Get();

        [HttpGet("{id}", Name = "GetSeries")]
        public ActionResult<List<Series>> Get(int id)
        {
            var series = _seriesService.Get(id);

            if (series == null)
            {
                return NotFound();
            }

            return series;
        }
    }
}
