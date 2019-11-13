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
        [HttpPost]
        public ActionResult<Customer> Create(Customer customer)
        {
            _customerService.Create(customer);
            return CreatedAtRoute("GetCustomer", new { id = customer.Id.ToString() }, customer);
        }
        [HttpPut]
        public IActionResult Update(string id,Customer customerIn)
        {
            var customer = _customerService.Get(id);
            if (customer == null)
            {
                return NotFound();
            }
            _customerService.Update(id, customerIn);
            return NoContent();
        }
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var customer = _customerService.Get(id);

            if (customer == null)
            {
                return NotFound();
            }

            _customerService.Remove(customer.Id);

            return NoContent();
        }
    }
}
