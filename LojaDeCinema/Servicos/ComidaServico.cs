using LojaDeCinema.Modelos;
using LojaDeCinema.Repositorios;
using LojaDeCinema.Repositorios.Interfaces;
using LojaDeCinema.Servicos.Interfaces;

namespace LojaDeCinema.Servicos
{
    public class ComidaServico : IComidaServico
    {
        private readonly IComidaRepositorio _comidaRepositorio;

        public ComidaServico(IComidaRepositorio comidaRepositorio) 
        {
            _comidaRepositorio = comidaRepositorio;
        }

        public async Task<List<ItemAlimentar>> ItemsAlimentarVendidos()
        {
            return await _comidaRepositorio.ItemsAlimentarVendidos();
        }

        public async Task<ItemAlimentar> BuscarPorId(int Id)
        {
            return await _comidaRepositorio.BuscarPorId(Id);
        }

        public async Task<ItemAlimentar> Adicionar(ItemAlimentar itemAlimentar)
        {
            return await _comidaRepositorio.Adicionar(itemAlimentar);
        }

        public async Task<ItemAlimentar> Actualizar(ItemAlimentar itemAlimentar, int Id)
        {
            return await _comidaRepositorio.Actualizar(itemAlimentar, Id);
        }

        public async Task<bool> Apagar(int Id)
        {
            return await _comidaRepositorio.Apagar(Id);
        }
    }
}
