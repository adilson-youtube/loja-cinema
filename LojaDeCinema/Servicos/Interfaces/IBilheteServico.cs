using LojaDeCinema.Modelos;

namespace LojaDeCinema.Servicos.Interfaces
{
    public interface IBilheteServico
    {
        Task<List<Bilhete>> BilhetesVendidos();
        Task<Bilhete> BuscarPorId(int Id);
        Task<Bilhete> Adicionar(Bilhete bilhete);
        Task<Bilhete> Actualizar(Bilhete bilhete, int Id);
        Task<bool> Apagar(int Id);

    }
}
