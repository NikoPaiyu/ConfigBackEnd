/* Customer Controller is used to display the customer details.
  url:https://localhost:44300/api/customers  */

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Config.CPQ.Models;
using Config.CPQ.Services;

namespace Config.CPQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController: ControllerBase
    {
        public readonly CustomerServices _customerService;
        public CustomersController(CustomerServices customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult<List<Customer>> Get() =>
            _customerService.Get();

        [HttpGet("{id:length(24)}",Name ="GetCustomer")]
        public ActionResult<Customer> Get(string id)
        {
            var customer = _customerService.Get(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
        
    }
}
