using System;
using System.Collections.Generic;
using System.Linq;
using Config.CPQ.ProductTable.Models;
using Config.ProductTable.Services;
using Microsoft.AspNetCore.Mvc;


namespace Config.ProductTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSettingsController : ControllerBase
    {
        private readonly ProductServices _productServices;

        public ProductSettingsController(ProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public ActionResult<List<Product>> Get() =>
            _productServices.Get();
        
        [HttpGet]
        [Route("{searchText}")]
        public ActionResult<List<Product>> Get(string searchText)
        {
            var product = _productServices.GetProductList(searchText);

            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        //[HttpGet("{id:length(24)}", Name = "GetProduct")]
        //public ActionResult<Product> Get(string id)
        //{
        //    var product = _productServices.Get(id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return product;
        //}

        //[HttpPost]
        //public ActionResult<Product> Create(Product product)
        //{
        //    _productServices.Create(product);

        //    return CreatedAtRoute("GetProduct", new { id = product.Id.ToString() }, product);
        //}

        //[HttpPut("{id:length(24)}")]
        //public IActionResult Update(string id, Product productIn)
        //{
        //    var product = _productServices.Get(id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    _productServices.Update(id, productIn);

        //    return NoContent();
        //}

       /* [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var product = _productServices.Get(id);

          if (product == null)
           {
             return NotFound();
           }

          _productServices.Remove(product.Id);

            return NoContent();
        }*/
        
    }
}