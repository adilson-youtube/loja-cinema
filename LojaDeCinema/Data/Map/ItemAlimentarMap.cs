using LojaDeCinema.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaDeCinema.Data.Map
{
    public class ItemAlimentarMap : IEntityTypeConfiguration<ItemAlimentar>
    {
        public void Configure(EntityTypeBuilder<ItemAlimentar> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.PrecoVenda).IsRequired();
            builder.Property(x => x.PrecoUnitario).IsRequired();
            builder.Property(x => x.Quantidade).IsRequired();
        }
    }
}
