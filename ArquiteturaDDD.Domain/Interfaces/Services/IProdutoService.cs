using System.Collections.Generic;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
