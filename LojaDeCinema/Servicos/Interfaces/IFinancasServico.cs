using LojaDeCinema.Modelos;

namespace LojaDeCinema.Servicos.Interfaces
{
    public interface IFinancasServico
    {
        Task<EstadoFinanceiro> EstatisticasEstadoFinanceiro();
    }
}
