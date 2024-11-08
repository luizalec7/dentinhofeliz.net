using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DentinhoFeliz.Application.Services;
using DentinhoFeliz.Domain.Entities;
using DentinhoFeliz.Application.ViewModels;

namespace DentinhoFeliz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CriancaController : ControllerBase
    {
        private readonly CriancaService _criancaService;

        public CriancaController(CriancaService criancaService)
        {
            _criancaService = criancaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var criancas = await _criancaService.GetAllCriancasAsync();
            return Ok(criancas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var crianca = await _criancaService.GetCriancaByIdAsync(id);
            if (crianca == null)
                return NotFound();

            return Ok(crianca);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CriancaViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var crianca = new Crianca
            {
                Nome = model.Nome,
                Idade = model.Idade,
                EmailResponsavel = model.EmailResponsavel
            };
            await _criancaService.AddCriancaAsync(crianca);
            return CreatedAtAction(nameof(GetById), new { id = crianca.Id }, crianca);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CriancaViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var crianca = await _criancaService.GetCriancaByIdAsync(id);
            if (crianca == null) return NotFound();

            crianca.Nome = model.Nome;
            crianca.Idade = model.Idade;
            crianca.EmailResponsavel = model.EmailResponsavel;

            await _criancaService.UpdateCriancaAsync(crianca);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var crianca = await _criancaService.GetCriancaByIdAsync(id);
            if (crianca == null) return NotFound();

            await _criancaService.DeleteCriancaAsync(id);
            return NoContent();
        }
    }
}