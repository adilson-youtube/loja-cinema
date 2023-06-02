using LojaDeCinema.Modelos;
using LojaDeCinema.Servicos;
using LojaDeCinema.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaDeCinema.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComidaControladora : ControllerBase
    {
        private readonly IComidaServico _comidaServico;

        public ComidaControladora(IComidaServico comidaServico) 
        {
            _comidaServico = comidaServico;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemAlimentar>>> ItemsAlimentarVendidos() 
        {
            List<ItemAlimentar> itemsVendidos = await _comidaServico.ItemsAlimentarVendidos();
            return Ok(itemsVendidos);
        }

        [HttpPost]
        public async Task<ActionResult<ItemAlimentar>> Cadastrar([FromBody] ItemAlimentar itemAlimentarRequeste)
        {
            return await _comidaServico.Adicionar(itemAlimentarRequeste);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ItemAlimentar>> Actualizar([FromBody] ItemAlimentar itemAlimentarRequeste, int id)
        {
            return await _comidaServico.Actualizar(itemAlimentarRequeste, id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemAlimentar>> BuscarPorId(int id)
        {
            return await _comidaServico.BuscarPorId(id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Apagar(int id)
        {
            return await _comidaServico.Apagar(id);
        }

    }
}
