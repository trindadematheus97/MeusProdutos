﻿using DevIO.Business.Core.Models;
using DevIO.Business.Models.Fornecedores.Validations;
using DevIO.Business.Models.Produtos;
using System.Collections.Generic;

namespace DevIO.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Produtos { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Produto> Produto { get; set; }
        public object Endereco { get; internal set; }
    }
}
