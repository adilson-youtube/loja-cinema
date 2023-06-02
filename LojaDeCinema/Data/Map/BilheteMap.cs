using LojaDeCinema.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaDeCinema.Data.Map
{
    public class BilheteMap : IEntityTypeConfiguration<Bilhete>
    {
        public void Configure(EntityTypeBuilder<Bilhete> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NomeFilme).IsRequired();
            builder.Property(x => x.PrecoVenda).IsRequired();
            builder.Property(x => x.Quantidade).IsRequired();
        }
    }
}
