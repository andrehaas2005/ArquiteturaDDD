

using System.Collections.Generic;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Domain.Interfaces.Repositories;
using ArquiteturaDDD.Domain.Interfaces.Services;

namespace ArquiteturaDDD.Domain.Services
{
   public class ProdutoService : ServiceBase<Produto> , IProdutoService
   {
       private readonly IProdutoRepository _produtoRepository;

       public ProdutoService(IProdutoRepository produtoRepository)
           : base(produtoRepository)
       {
           _produtoRepository = produtoRepository;
       }

       public IEnumerable<Produto> BuscarPorNome(string nome)
       {
           return _produtoRepository.BuscarPorNome(nome);
       }
   }
}
