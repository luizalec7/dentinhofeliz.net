using System.Collections.Generic;
using System.Threading.Tasks;
using DentinhoFeliz.Domain.Entities;
using DentinhoFeliz.Domain.Interfaces;

namespace DentinhoFeliz.Application.Services
{
    public class CriancaService
    {
        private readonly ICriancaRepository _criancaRepository;

        public CriancaService(ICriancaRepository criancaRepository)
        {
            _criancaRepository = criancaRepository;
        }

        public async Task<IEnumerable<Crianca>> GetAllCriancasAsync()
        {
            return await _criancaRepository.GetAllAsync();
        }

        public async Task<Crianca> GetCriancaByIdAsync(int id)
        {
            return await _criancaRepository.GetByIdAsync(id);
        }

        public async Task AddCriancaAsync(Crianca crianca)
        {
            await _criancaRepository.AddAsync(crianca);
        }

        public async Task UpdateCriancaAsync(Crianca crianca)
        {
            await _criancaRepository.UpdateAsync(crianca);
        }

        public async Task DeleteCriancaAsync(int id)
        {
            await _criancaRepository.DeleteAsync(id);
        }
    }
}