using LojaDeCinema.Modelos;
using LojaDeCinema.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaDeCinema.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilheteControladora : ControllerBase
    {
        private readonly IBilheteServico _bilheteServico;

        public BilheteControladora(IBilheteServico bilheteServico) 
        {
            _bilheteServico = bilheteServico;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bilhete>>> BuscarTodosBilhetesVendidos() 
        {
            List<Bilhete> bilhetes = await _bilheteServico.BilhetesVendidos();
            return Ok(bilhetes);
        }

        [HttpPost]
        public async Task<ActionResult<Bilhete>> Cadastrar([FromBody] Bilhete bilheteRequeste) 
        {
            return await _bilheteServico.Adicionar(bilheteRequeste);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Bilhete>> Actualizar([FromBody] Bilhete bilheteRequeste, int id) 
        {
            return await _bilheteServico.Actualizar(bilheteRequeste, id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bilhete>> BuscarPorId(int id) 
        {
            return await _bilheteServico.BuscarPorId(id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Apagar(int id) 
        {
            return await _bilheteServico.Apagar(id);
        }
    }
}
