using DevIO.Business.Models.Fornecedores;
using System;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DevIO.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
               .Include(f => f.Produtos)
               .Include(f => f.Produtos)
               .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
