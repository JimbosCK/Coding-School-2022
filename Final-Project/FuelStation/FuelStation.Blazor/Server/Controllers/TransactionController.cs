﻿using FuelStation.Blazor.Shared.Services;
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
            var transactionViewModels = new List<TransactionViewModel>();

            var transactions = await _transactionRepo.GetAllAsync();
            
            foreach (var transaction in transactions)
            {
                var transactionCustomer = await _customerRepo.GetByIdAsync(transaction.CustomerID);
                var customerCardNumber = transactionCustomer is not null ? transactionCustomer.CardNumber : "N/A";
                var transactionEmployee = await _employeeRepo.GetByIdAsync(transaction.EmployeeID);
                var employeeName = transactionEmployee is not null ? transactionEmployee.FullName : "N/A";

                transactionViewModels.Add(new TransactionViewModel()
                {
                    ID = transaction.ID,
                    Date = transaction.Date,
                    CustomerID = transaction.CustomerID,
                    CustomerCardNumber = customerCardNumber,
                    EmployeeID = transaction.EmployeeID,
                    EmployeeName = employeeName,
                    PaymentMethod = transaction.PaymentMethod,
                    TotalValue = transaction.TotalValue,
                    TransactionLines = transaction.TransactionLines
                });
            }
            return transactionViewModels;
        }

    }
}
