using ArquiteturaDDD.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
