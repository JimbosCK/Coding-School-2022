using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedgerController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<FuelStationShop> _fuelStationRepo;
        private readonly LedgerHandler _ledgerHandler;

        public LedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo,
            IEntityRepo<FuelStationShop> fuelStationRepo, LedgerHandler ledgerHandler)
        {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _ledgerHandler = ledgerHandler;
            _fuelStationRepo = fuelStationRepo;

        }

        [HttpGet("fuelstation")]
        public async Task<FuelStationShopViewModel?> Get()
        {
            var fuelStation = await _fuelStationRepo.GetAllAsync();
            if (fuelStation is null) return null;
            return new FuelStationShopViewModel()
            {
                ID = fuelStation.First().ID,
                MonthlyRentCost = fuelStation.First().MonthlyRent
            };
        }

        [HttpPut("fuelstation")]
        public async Task<ActionResult> Put(FuelStationShopViewModel fuelStation)
        {
            try
            {
                var fuelStationToUpdate = await _fuelStationRepo.GetByIdAsync(fuelStation.ID);

                if (fuelStationToUpdate is null) return NotFound($"Employee with Id = {fuelStation.ID} not found");

                await _fuelStationRepo.UpdateAsync(fuelStation.ID, new FuelStationShop()
                {
                    MonthlyRent = fuelStation.MonthlyRentCost
                });

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }

        }

        [HttpGet("{year}/{month}")]
        public async Task<LedgerViewModel> Get(int year, int month)
        {
            var transactions = await _transactionRepo.GetAllAsync();
            var employees = await _employeeRepo.GetAllAsync();
            var fuelShop = await _fuelStationRepo.GetAllAsync();
            if (fuelShop is null) return null;
            return _ledgerHandler.MakeLedger(employees, transactions, fuelShop.First().MonthlyRent , year, month);
        }
    }
}
