using DevIO.Business.Core.Notificacoes;
using DevIO.Business.Core.Services;
using DevIO.Business.Core.Validations.Documents;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Fornecedores.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private IFornecedorRepository fornecedorRepository;
        private IEnderecoRepository enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, 
                                 IEnderecoRepository enderecoRepository,
                                 INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
        }

       

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

            await _fornecedorRepository.Adicionar(fornecedor);



        }

        public Task Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }


        public async Task Remover(Guid id)
        {
            var fornecedor = await _fornecedorRepository.ObterFornecedorProdutosEndereco(id);

            if (fornecedor.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrados!");
                return;
            }

            if (fornecedor.Produtos.Any()) return;

            if(fornecedor.Endereco != null)
            {
                await _enderecoRepository.Remover(fornecedor.Endereco.Id);
            }
            await _fornecedorRepository.Remover(id);

        }


        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            await _enderecoRepository.Atualizar(endereco);
        }

        private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var fornecedorAtual = await _fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento
            && f.Id != fornecedor.Id);
            if (!fornecedorAtual.Any()) return false;

            Notificar("Já existe um fornecedor com este documento informado.");
            return true;
        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
            _fornecedorRepository?.Dispose();
        }
    }
}
