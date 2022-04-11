
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly EmployeeHandler _employeeHandler;
        public EmployeeController(IEntityRepo<Employee> employeeRepo, EmployeeHandler employeeHandler)
        {
            _employeeRepo = employeeRepo;
            _employeeHandler = employeeHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get()
        {
            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeListViewModel
            {
                ID = x.ID,
                FullName = x.FullName,
                EmployeeType = x.EmployeeType,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd,
                SallaryPerMonth = x.SallaryPerMonth,
                Username = x.Username
            });
        }

        [HttpGet("{id}")]
        public async Task<EmployeeViewModel?> Get(Guid id)
        {
            EmployeeViewModel employee = new();
            try
            {
                if (id != Guid.Empty)
                {
                    var oldEmployee = await _employeeRepo.GetByIdAsync(id);
                    if (oldEmployee is null) return null;

                    employee.ID = oldEmployee.ID;
                    employee.Name = oldEmployee.Name;
                    employee.Surname = oldEmployee.Surname;
                    employee.EmployeeType = oldEmployee.EmployeeType;
                    employee.HireDateStart = oldEmployee.HireDateStart;
                    employee.HireDateEnd = oldEmployee.HireDateEnd;
                    employee.SallaryPerMonth = oldEmployee.SallaryPerMonth;
                    employee.Username = oldEmployee.Username;
                    employee.Password = oldEmployee.Password;
                }
                return employee;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<EmployeeListViewModel>> Delete(Guid id)
        {
            try
            {
                var employeeToDelete = await _employeeRepo.GetByIdAsync(id);

                if (employeeToDelete is null) return NotFound($"Employee with Id = {id} not found");

                await _employeeRepo.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(EmployeeViewModel employee)
        {
            try
            {
                if (!_employeeHandler.HasValidData(employee))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                    "The request was well-formed but was unable to be followed due to semantic errors. Check format of data.");
                }

                await _employeeRepo.CreateAsync(new Employee()
                {
                    Name = employee.Name,
                    Surname = employee.Surname,
                    EmployeeType = employee.EmployeeType,
                    HireDateStart = employee.HireDateStart,
                    HireDateEnd = employee.HireDateEnd,
                    SallaryPerMonth = employee.SallaryPerMonth,
                    Username = employee.Username,
                    Password = employee.Password
                });
                return Ok();
            }
            catch (Exception e)
            {
                if (e is Microsoft.Data.SqlClient.SqlException)
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. 'Employee.ID' might already exist in database.");
                }
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeViewModel employee)
        {
            try
            {
                var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);

                if (employeeToUpdate is null) return NotFound($"Employee with Id = {employee.ID} not found");

                if (!_employeeHandler.HasValidData(employee))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. Check format.");
                }

                await _employeeRepo.UpdateAsync(employee.ID, new Employee()
                {
                    Name = employee.Name,
                    Surname = employee.Surname,
                    EmployeeType = employee.EmployeeType,
                    HireDateStart = employee.HireDateStart,
                    HireDateEnd = employee.HireDateEnd,
                    SallaryPerMonth = employee.SallaryPerMonth,
                    Username = employee.Username,
                    Password = employee.Password
                });

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }

        }

        [HttpPut("terminate")]
        public async Task<ActionResult> PutTerminate(EmployeeListViewModel employee)
        {
            try
            {
                var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);

                if (employeeToUpdate is null) return NotFound($"Employee with Id = {employee.ID} not found");

                if (!_employeeHandler.HasValidData(employee))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. Check format.");
                }

                await _employeeRepo.UpdateAsync(employee.ID, new Employee()
                {
                    Name = employeeToUpdate.Name,
                    Surname = employeeToUpdate.Surname,
                    EmployeeType = employeeToUpdate.EmployeeType,
                    HireDateStart = employeeToUpdate.HireDateStart,
                    HireDateEnd = DateTime.Now,
                    SallaryPerMonth = employeeToUpdate.SallaryPerMonth,
                    Username = employeeToUpdate.Username,
                    Password = employeeToUpdate.Password
                });

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }

        }

        [HttpPut("undoterminate")]
        public async Task<ActionResult> PutUndoTerminate(EmployeeListViewModel employee)
        {
            try
            {
                var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.ID);

                if (employeeToUpdate is null) return NotFound($"Employee with Id = {employee.ID} not found");

                if (!_employeeHandler.HasValidData(employee))
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. Check format.");
                }

                await _employeeRepo.UpdateAsync(employee.ID, new Employee()
                {
                    Name = employeeToUpdate.Name,
                    Surname = employeeToUpdate.Surname,
                    EmployeeType = employeeToUpdate.EmployeeType,
                    HireDateStart = employeeToUpdate.HireDateStart,
                    HireDateEnd = null,
                    SallaryPerMonth = employeeToUpdate.SallaryPerMonth,
                    Username = employeeToUpdate.Username,
                    Password = employeeToUpdate.Password
                }); ;

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
