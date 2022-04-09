
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly ApplicationContext context;
        public EmployeeRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }

        public async Task CreateAsync(Employee entity)
        {
            context.Employees.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var dbProd = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Employees.Remove(dbProd);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            var dbProd = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (dbProd is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


            
            dbProd.Name = entity.Name;
            dbProd.Surname = entity.Surname;
            dbProd.HireDateStart = entity.HireDateStart;
            dbProd.HireDateEnd = entity.HireDateEnd;
            dbProd.SallaryPerMonth = entity.SallaryPerMonth;
            dbProd.EmployeeType = entity.EmployeeType;
            dbProd.Username = entity.Username;
            dbProd.Password = entity.Password;
        }
    }
}
