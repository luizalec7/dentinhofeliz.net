using DentinhoFeliz.Application.Services;
using DentinhoFeliz.Application.DTOs;
using DentinhoFeliz.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<IEnumerable<CriancaDto>>> GetAll()
        {
            var criancas = await _criancaService.GetAllCriancasAsync();
            return Ok(criancas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CriancaDto>> GetById(int id)
        {
            var crianca = await _criancaService.GetCriancaByIdAsync(id);
            if (crianca == null) return NotFound();
            return Ok(crianca);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CriancaDto criancaDto)
        {
            var crianca = new Crianca { Nome = criancaDto.Nome, Idade = criancaDto.Idade, EmailResponsavel = criancaDto.EmailResponsavel };
            await _criancaService.AddCriancaAsync(crianca);
            return CreatedAtAction(nameof(GetById), new { id = crianca.Id }, crianca);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CriancaDto criancaDto)
        {
            var crianca = new Crianca { Id = id, Nome = criancaDto.Nome, Idade = criancaDto.Idade, EmailResponsavel = criancaDto.EmailResponsavel };
            await _criancaService.UpdateCriancaAsync(crianca);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _criancaService.DeleteCriancaAsync(id);
            return NoContent();
        }
    }
}
