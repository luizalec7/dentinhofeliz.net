using DentinhoFeliz.Domain.Entities;

namespace DentinhoFeliz.Domain.Interfaces
{
    public interface ICriancaRepository
    {
        Task<Crianca> GetByIdAsync(int id);
        Task<IEnumerable<Crianca>> GetAllAsync();
        Task AddAsync(Crianca crianca);
        Task UpdateAsync(Crianca crianca);
        Task DeleteAsync(int id);
    }
}
