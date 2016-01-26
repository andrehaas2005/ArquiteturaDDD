using System.Data.Entity.ModelConfiguration;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Infra.Data.EntitiesConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.Sobrenome).IsRequired().HasMaxLength(150);
            Property(c => c.Email).IsRequired();


        }

    }
}
