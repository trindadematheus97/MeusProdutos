using DevIO.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {

        public EnderecoConfig()
        {
            ToTable("Enderecos");

            HasKey(x => x.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(x => x.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(s => s.Estado)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Enderecos");

        }
    }
}
