using LojaDeCinema.Modelos;
using LojaDeCinema.Servicos;
using LojaDeCinema.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaDeCinema.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancasControladora : ControllerBase
    {
        private readonly Servicos.Interfaces.IFinancasServico _financasServico;

        public FinancasControladora(Servicos.Interfaces.IFinancasServico financasServico) 
        {
            _financasServico = financasServico;
        }

        [HttpGet]
        public async Task<ActionResult<EstadoFinanceiro>> Index() 
        {
            EstadoFinanceiro estadoFinanceiro = await _financasServico.EstatisticasEstadoFinanceiro();
            return Ok(estadoFinanceiro);
        }
    }
}
