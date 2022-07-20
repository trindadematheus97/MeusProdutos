﻿using DevIO.Business.Models.Fornecedores;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace DevIO.Infra.Data.Mappings
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        internal FornecedorConfig()
        {
            ToTable("Fornecedores");

            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento",
                new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(f => f.Endereco)
                .WithRequiredPrincipal(e => (Fornecedor)e.Fornecedor);

            ToTable("Fornecedores");
            

        }
    }
}
