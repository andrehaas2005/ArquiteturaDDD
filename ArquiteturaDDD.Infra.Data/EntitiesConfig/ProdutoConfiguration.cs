using System.Data.Entity.ModelConfiguration;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Infra.Data.EntitiesConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.Nome).IsRequired().HasMaxLength(250);
            Property(p => p.Valor).IsRequired();
            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteId);
        }

    }
}
