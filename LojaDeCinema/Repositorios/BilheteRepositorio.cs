using LojaDeCinema.Data;
using LojaDeCinema.Modelos;
using LojaDeCinema.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaDeCinema.Repositorios
{
    public class BilheteRepositorio : IBilheteRepositorio
    {
        private readonly LojaDeCinemaDBContex _dbContext;
        public BilheteRepositorio(LojaDeCinemaDBContex dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<Bilhete>> BilhetesVendidos()
        {
            return await _dbContext.Bilhetes.ToListAsync();
        }

        public async Task<Bilhete> BuscarPorId(int Id)
        {
            return await _dbContext.Bilhetes.FirstOrDefaultAsync(x => x.ID == Id);
        }

        public async Task<Bilhete> Adicionar(Bilhete bilhete)
        {
            await _dbContext.Bilhetes.AddAsync(bilhete);
            _dbContext.SaveChangesAsync();
            return bilhete;
        }

        public async Task<Bilhete> Actualizar(Bilhete bilhete, int Id)
        {
            Bilhete BilhetePorId = await BuscarPorId(Id);
            if(BilhetePorId == null) 
            {
                throw new Exception($"Bilhete com o ID {Id} não foi encontrado na BD");
            }

            BilhetePorId.NomeFilme = bilhete.NomeFilme;
            BilhetePorId.PercentagemCorteStudio = bilhete.PercentagemCorteStudio;
            BilhetePorId.PrecoVenda = bilhete.PrecoVenda;

            _dbContext.Bilhetes.Update(BilhetePorId);
            await _dbContext.SaveChangesAsync();
            return bilhete;
        }

        public async Task<bool> Apagar(int Id)
        {
            Bilhete BilhetePorId = await BuscarPorId(Id);
            if (BilhetePorId == null) 
            {
                throw new Exception($"Bilhete com o ID {Id} não foi encontrado na BD");
            }

            _dbContext.Remove(BilhetePorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
