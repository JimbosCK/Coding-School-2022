using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transactionLineRepo,
            IEntityRepo<Employee> employeeRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo)
        {
            _transactionRepo = transactionRepo;
            _transactionLineRepo = transactionLineRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionViewModel>> Get()
        {
            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionViewModel
            {
                ID = x.ID,
                Date = x.Date,
                CustomerID = x.CustomerID,
                EmployeeID = x.EmployeeID,
                PaymentMethod  =x.PaymentMethod,
                TotalValue = x.TotalValue,
                TransactionLines = x.TransactionLines
            });
        }

    }
}
