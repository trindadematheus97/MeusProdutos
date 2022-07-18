using DevIO.Business.Core.Data;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Produtos
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<object> ObterProdutoFornecedor(object id);
    }
}

