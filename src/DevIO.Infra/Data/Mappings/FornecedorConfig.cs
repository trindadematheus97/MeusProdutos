﻿using DevIO.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace DevIO.Infra.Data.Mappings
{
    internal class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f=> f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento",
                new IndexAnnotation(new IndexAttribute { IsUnique = true}));

            HasRequired(f => f.Endereco)
                .WithRequiredPrincipal(e=> e.Fornecedor);

            ToTable("Fornecedores");
            

        }
    }
}
