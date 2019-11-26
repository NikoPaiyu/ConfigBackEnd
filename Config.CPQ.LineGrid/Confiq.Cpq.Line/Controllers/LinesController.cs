using Confiq.Cpq.Line.Models;
using Confiq.Cpq.Line.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
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
            [Route("{quoteNumber}/{prtid}")]
            public ActionResult<Lines> Create(string quotenumber,string prtid)
            {
                return   _lineService.CreateLine(quotenumber,prtid);
            
          
            }

        //[HttpPost]
        //[Route("{Id}")]
        //public ActionResult<Lines> Update(Lines line)
        //{
            
        //    _lineService.Update(line.Id, line);
        //    return line;
        //}

        //[HttpPost]
        //[Route("{Id}")]
        //public Lines Update(string Id, Lines line)
        //{

        //    _lineService.Update(line.Id, line);
        //    return line;
        //}

        [HttpPost]
        [Route("{Id}")]
        public string Update(string id,Lines Lines)
        {

            var mongo = new MongoClient();

            var db = mongo.GetDatabase("LineListDb");

            var collection = db.GetCollection<Lines>("Line");


          //  var filter = new BsonDocument("id", Lines.Id);

          ////  var filter = Builders<BsonDocument>.Filter.Eq("Id", Lines.Id);

          //  var document = collection.Find(filter).First();

          //  var update = Builders<BsonDocument>.Update.Set("Quantity", Lines.Quantity);

          //  var result=collection.UpdateOne(filter, update);



            var filter = Builders<Lines>.Filter.Eq("Id", Lines.Id);
            var update = Builders<Lines>.Update.Set("Quantity", Lines.Quantity);
            collection.UpdateOne(filter, update);
            return "Quantity" + Lines.Quantity;
        //    collection.FindOneAndReplace(Builders<Lines>.Filter.Eq("Id", Lines.Id), Builders<Lines>.Update.Set("Quantity", Lines.Quantity));

        //    return "Quantity"+Lines.Quantity;

        }



        //public ActionResult<Lines> UpdateMany(Lines line)
        //{
        //    var updmanyresult = await collection.UpdateManyAsync(
        //Lines<BsonDocument>.Filter.Gt("MasterID", 100),
        //                        Builders<BsonDocument>.Update.Inc("MasterID", 10))
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

