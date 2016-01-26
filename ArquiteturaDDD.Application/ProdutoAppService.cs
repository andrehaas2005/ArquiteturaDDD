using ArquiteturaDDD.Application.Interface;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ArquiteturaDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }


        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
