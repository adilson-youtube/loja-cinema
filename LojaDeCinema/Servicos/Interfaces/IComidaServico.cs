using LojaDeCinema.Modelos;

namespace LojaDeCinema.Servicos.Interfaces
{
    public interface IComidaServico
    {
        Task<List<ItemAlimentar>> ItemsAlimentarVendidos();
        Task<ItemAlimentar> BuscarPorId(int Id);
        Task<ItemAlimentar> Adicionar(ItemAlimentar itemAlimentar);
        Task<ItemAlimentar> Actualizar(ItemAlimentar itemAlimentar, int Id);
        Task<bool> Apagar(int Id);
    }
}
