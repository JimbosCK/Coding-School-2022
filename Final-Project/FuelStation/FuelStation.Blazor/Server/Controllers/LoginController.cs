using FuelStation.Blazor.Client.Shared;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly LoginHandler _loginHandler;
        public LoginController(IEntityRepo<Employee> employeeRepo, LoginHandler loginHandler)
        {
            _employeeRepo = employeeRepo;
            _loginHandler = loginHandler;
        }

        [HttpGet("{username}/{password}")]
        public async Task<VerifiedEmployeeViewModel?> Get(string username, string password)
        {
            VerifiedEmployeeViewModel employee = new();

            if (_loginHandler.HasInvalidCredentials(username, password))
                return null;

            if (_loginHandler.IsAdministrator(username, password))
            {
                employee = new()
                {
                    ID = Guid.NewGuid(),
                    Username = username,
                    FullName = "Administrator",
                    EmployeeType = EmployeeTypeEnum.Administrator
                };
            }else
            {
                var employees = await _employeeRepo.GetAllAsync();
                var foundEmployee = employees.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (foundEmployee is not null)
                {
                    employee = new()
                    {
                        ID = foundEmployee.ID,
                        Username = foundEmployee.Username,
                        FullName = foundEmployee.FullName,
                        EmployeeType = foundEmployee.EmployeeType
                    };
                }
            }

            return employee;
        }
    }
}
