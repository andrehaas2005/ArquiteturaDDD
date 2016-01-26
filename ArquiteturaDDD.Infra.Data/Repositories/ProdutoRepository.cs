

using System.Collections.Generic;
using System.Linq;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Domain.Interfaces;
using ArquiteturaDDD.Domain.Interfaces.Repositories;

namespace ArquiteturaDDD.Infra.Data.Repositories
{
  public class ProdutoRepository : RepositoryBase<Produto>,IProdutoRepository
  {
      public IEnumerable<Produto> BuscarPorNome(string Nome)
      {
          return Db.Produtos.Where(p => p.Nome == Nome);
      }
  }
}
