﻿/*Pricing and Terms controller is used to get country, currency and Terms of Delivery details 
 URL: https://localhost:44344/api/pricing"   */

using System;
using System.Collections.Generic;
using System.Linq;
using Config.CPQ.Pricing.Models;
using Config.CPQ.Pricing.Services;
using Microsoft.AspNetCore.Mvc;


namespace Config.CPQ.Pricing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly PricingServices _pricingServices;

        public PricingController(PricingServices pricServices)
        {
            _pricingServices = pricServices;
        }

        [HttpGet]
        public ActionResult<List<Models.Pricing>> Get() =>
            _pricingServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetPricing")]
        public ActionResult<Models.Pricing> Get(string id)
        {
            var pricing = _pricingServices.Get(id);

            if (pricing == null)
            {
                return NotFound();
            }

            return pricing;
        }

       
    }
}
