using System.Collections.Generic;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
