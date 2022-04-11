
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly CustomerHandler _customerHandler;
        public CustomerController(IEntityRepo<Customer> customerRepo, CustomerHandler customerHandler)
        {
            _customerRepo = customerRepo;
            _customerHandler = customerHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerListViewModel
            {
                ID = x.ID,
                FullName = x.FullName,
                CardNumber = x.CardNumber
            });
        }

        [HttpGet("{id}")]
        public async Task<CustomerViewModel?> Get(Guid id)
        {
            CustomerViewModel customer = new();
            try
            {
                if (id != Guid.Empty)
                {
                    var oldCustomer = await _customerRepo.GetByIdAsync(id);
                    if (oldCustomer is null) return null;

                    customer.ID = oldCustomer.ID;
                    customer.Name = oldCustomer.Name;
                    customer.Surname = oldCustomer.Surname;
                    customer.CardNumber = oldCustomer.CardNumber;
                }
                return customer;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<CustomerListViewModel>> Delete(Guid id)
        {
            try
            {
                var customerToDelete = await _customerRepo.GetByIdAsync(id);

                if (customerToDelete is null) return NotFound($"Customer with Id = {id} not found");

                await _customerRepo.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(CustomerViewModel customer)
        {
            try
            {
                if( !_customerHandler.HasValidData(customer))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. Check format of 'Name', 'Surname' and 'CardNumber'.");
                }
                var newCustomer = new Customer()
                {
                    Name = customer.Name,
                    Surname = customer.Surname,
                    CardNumber = customer.CardNumber
                };

                await _customerRepo.CreateAsync(newCustomer);
                return Ok();
            }
            catch (Exception e)
            {
                if (e is Microsoft.Data.SqlClient.SqlException)
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. 'Customer.CardNumber' might already exist in database.");
                }
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerViewModel customer)
        {
            try
            {
                var customerToUpdate = await _customerRepo.GetByIdAsync(customer.ID);

                if (customerToUpdate is null) return NotFound($"Item with Id = {customer.ID} not found");

                if (!_customerHandler.HasValidData(customer))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. Check format of 'Name', 'Surname' and 'CardNumber'.");
                }

                await _customerRepo.UpdateAsync(customer.ID, new Customer()
                {
                    Name = customer.Name,
                    Surname = customer.Surname,
                    CardNumber = customer.CardNumber
                });

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }

        }
    }
}
