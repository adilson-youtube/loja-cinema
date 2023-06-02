using LojaDeCinema.Modelos;
using LojaDeCinema.Repositorios.Interfaces;
using LojaDeCinema.Servicos.Interfaces;

namespace LojaDeCinema.Servicos
{
    public class BilheteServico : IBilheteServico
    {
        private readonly IBilheteRepositorio _bilheteRepositorio;

        public BilheteServico(IBilheteRepositorio bilheteRepositorio) 
        {
            _bilheteRepositorio = bilheteRepositorio;
        }

        public async Task<Bilhete> BuscarPorId(int Id)
        {
            return await _bilheteRepositorio.BuscarPorId(Id);
        }

        public async Task<List<Bilhete>> BilhetesVendidos()
        {
            return await _bilheteRepositorio.BilhetesVendidos();
        }

        public async Task<Bilhete> Adicionar(Bilhete bilhete)
        {
            return await _bilheteRepositorio.Adicionar(bilhete);
        }

        public async Task<Bilhete> Actualizar(Bilhete bilhete, int Id)
        {
            return await _bilheteRepositorio.Actualizar(bilhete, Id);
        }

        public async Task<bool> Apagar(int Id)
        {
            return await _bilheteRepositorio.Apagar(Id);
        }
    }
}
