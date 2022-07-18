﻿using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevIO.AppMvc.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController()
        {
            
        }


        public async Task<ActionResult> Index()
        {
            var fornecedor = new Fornecedor()
            {
                Nome = "",
                Documento ="11111111111",
                Endereco = new Endereco(),
                TipoFornecedor = TipoFornecedor.PessoaFisica,
                Ativo = true

            };

            await _fornecedorService.Adicionar(fornecedor);

            return new EmptyResult();
        }

    }
}