using System.Collections.Generic;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Domain.Interfaces.Repositories
{
   public interface IProdutoRepository : IRepositoryBase<Produto>
   {
       IEnumerable<Produto> BuscarPorNome(string Nome);

   }
}
