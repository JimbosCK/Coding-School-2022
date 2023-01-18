
using FuelStation.Model;

namespace FuelStation.EF.Repositories
{
    public interface IEntityRepo<TEntity>
              where TEntity : BaseEntity
    {

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Guid id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(Guid id, TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
