using Application.Customer.DTOs;
using Application.Customer.Ports;
using Application.Customer.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerManager _customerManager;

        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }


        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> Get(int id)
        {
            var result = await _customerManager.GetCustomer(id);
            return Ok(result.Data);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<CustomerDTO>> Post([FromBody] CustomerDTO customer)
        {
            var request = new CreateCustomerRequest
            {
                Data = customer
            };

            var result = await _customerManager.CreateCustomer(request);
            return Created("", result.Data);
        }

 
    }
}
