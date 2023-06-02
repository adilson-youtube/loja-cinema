using LojaDeCinema.Modelos;

namespace LojaDeCinema.Repositorios.Interfaces
{
    public interface IBilheteRepositorio
    {
        Task<List<Bilhete>> BilhetesVendidos();
        Task<Bilhete> Adicionar(Bilhete bilhete);
        Task<Bilhete> BuscarPorId(int Id);
        Task<Bilhete> Actualizar(Bilhete bilhete, int Id);
        Task<bool> Apagar(int Id);
    }
}
