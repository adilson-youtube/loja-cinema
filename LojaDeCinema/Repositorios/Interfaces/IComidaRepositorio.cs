using LojaDeCinema.Modelos;

namespace LojaDeCinema.Repositorios.Interfaces
{
    public interface IComidaRepositorio
    {
        Task<List<ItemAlimentar>> ItemsAlimentarVendidos();
        Task<ItemAlimentar> BuscarPorId(int Id);
        Task<ItemAlimentar> Adicionar(ItemAlimentar itemAlimentar);
        Task<ItemAlimentar> Actualizar(ItemAlimentar itemAlimentar, int Id);
        Task<bool> Apagar(int Id);
    }
}
