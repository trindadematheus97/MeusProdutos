using DevIO.Business.Models.Produtos;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using DevIO.Infra.Data.Context;

namespace DevIO.Infra.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }
        public  async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<object> ObterProdutoFornecedor(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
