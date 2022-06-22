﻿using DevIO.Business.Core.Models;
using DevIO.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Produtos
{
    internal class Produto : Entity
    {
        public Guid Id { get; set;  }

        public string Nome { get; set;  }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public Fornecedor fornecedor { get; set;  }
    }
}