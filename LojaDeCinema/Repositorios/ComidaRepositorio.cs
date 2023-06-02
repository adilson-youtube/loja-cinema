using LojaDeCinema.Data;
using LojaDeCinema.Modelos;
using LojaDeCinema.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaDeCinema.Repositorios
{
    public class ComidaRepositorio : IComidaRepositorio
    {
        private readonly LojaDeCinemaDBContex _dbContex;
        public ComidaRepositorio(LojaDeCinemaDBContex lojaDeCinemaDBContex) 
        {
            _dbContex = lojaDeCinemaDBContex;
        }

        public async Task<List<ItemAlimentar>> ItemsAlimentarVendidos()
        {
            return await _dbContex.itemsAlimentar.ToListAsync();
        }

        public async Task<ItemAlimentar> BuscarPorId(int Id)
        {
            return await _dbContex.itemsAlimentar.FirstOrDefaultAsync(x => x.ID == Id);
        }

        public async Task<ItemAlimentar> Adicionar(ItemAlimentar itemAlimentar)
        {
            await _dbContex.itemsAlimentar.AddAsync(itemAlimentar);
            await _dbContex.SaveChangesAsync();
            return itemAlimentar;
        }

        public async Task<ItemAlimentar> Actualizar(ItemAlimentar itemAlimentar, int Id)
        {
            ItemAlimentar itemPorId = await BuscarPorId(Id);
            
            if(itemPorId == null) 
            {
                throw new Exception($"Item Alimentar com o ID: {Id} não foi encontrado na BD");
            }

            itemPorId.Nome = itemAlimentar.Nome;
            itemPorId.PrecoVenda = itemAlimentar.PrecoVenda;
            itemPorId.PrecoUnitario = itemAlimentar.PrecoUnitario;
            itemPorId.Quantidade = itemAlimentar.Quantidade;

            _dbContex.itemsAlimentar.Update(itemPorId);
            await _dbContex.SaveChangesAsync();
            return itemAlimentar;
        }

        public async Task<bool> Apagar(int Id)
        {
            ItemAlimentar itemPorId = await BuscarPorId(Id);
            if(itemPorId == null) 
            {
                throw new Exception($"Item Alimentar com ID: {Id} não foi encontrado na BD");
            }

            _dbContex.itemsAlimentar.Remove(itemPorId);
            await _dbContex.SaveChangesAsync();
            return true;
        }


    }
}
