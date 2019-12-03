//This controller is used to add products in the line grid
//URL: http://localhost:44365/api/productsettings
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
        
    }
}