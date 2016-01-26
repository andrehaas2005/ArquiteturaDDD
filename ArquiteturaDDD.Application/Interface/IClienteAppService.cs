using System.Collections.Generic;
using ArquiteturaDDD.Domain.Entities;

namespace ArquiteturaDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspecial();
    }
}
