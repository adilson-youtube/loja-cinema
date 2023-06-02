using LojaDeCinema.Modelos;
using LojaDeCinema.Repositorios.Interfaces;
using LojaDeCinema.Servicos.Interfaces;

namespace LojaDeCinema.Servicos
{
    public class FinancasServico : IFinancasServico
    {
        private readonly IBilheteRepositorio _bilheteRepositorio;
        private readonly IComidaRepositorio _comidaRepositorio;

        public FinancasServico(IBilheteRepositorio bilheteRepositorio, IComidaRepositorio comidaRepositorio) 
        {
            _bilheteRepositorio = bilheteRepositorio;
            _comidaRepositorio = comidaRepositorio;
        }

        public async Task<EstadoFinanceiro> EstatisticasEstadoFinanceiro()
        {
            EstadoFinanceiro estadoFinanceiro = new EstadoFinanceiro();
            List<ItemAlimentar> comidaVendida = await _comidaRepositorio.ItemsAlimentarVendidos();
            List<Bilhete> bilhetesVendido = await _bilheteRepositorio.BilhetesVendidos();

            //Calcular estatísticas médias
            estadoFinanceiro.LucroMedioBilhete = bilhetesVendido.Sum(x => x.Lucro) / bilhetesVendido.Sum(x => x.Quantidade);
            estadoFinanceiro.LucroMedioItemComida = comidaVendida.Sum(x => x.Lucro) / comidaVendida.Sum(x => x.Quantidade);
            return estadoFinanceiro;
        }
    }
}
