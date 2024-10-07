using DentinhoFeliz.Domain.Entities;
using DentinhoFeliz.Domain.Interfaces;
using DentinhoFeliz.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DentinhoFeliz.Infrastructure.Repositories
{
    public class CriancaRepository : ICriancaRepository
    {
        private readonly DentinhoFelizDbContext _context;

        public CriancaRepository(DentinhoFelizDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Crianca>> GetAllAsync()
        {
            return await _context.Criancas.ToListAsync();
        }

        public async Task<Crianca> GetByIdAsync(int id)
        {
            return await _context.Criancas.FindAsync(id);
        }

        public async Task AddAsync(Crianca crianca)
        {
            await _context.Criancas.AddAsync(crianca);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Crianca crianca)
        {
            _context.Criancas.Update(crianca);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var crianca = await _context.Criancas.FindAsync(id);
            if (crianca != null)
            {
                _context.Criancas.Remove(crianca);
                await _context.SaveChangesAsync();
            }
        }
    }
}
