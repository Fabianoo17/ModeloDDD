

using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto> , IProdutoRepository
    {

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
