
using System.Collections.Generic;
using ArquiteturaDDD.Application.Interface;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Domain.Interfaces.Services;

namespace ArquiteturaDDD.Application
{
  
   public class ClienteAppService : AppServiceBase<Cliente>,IClienteAppService
   {
       private readonly IClienteService _clienteService;


       public ClienteAppService(IClienteService clienteService) : base(clienteService)
       {
           _clienteService = clienteService;
       }

       public IEnumerable<Cliente> ObterClienteEspecial()
       {
           return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
       }
   }
}
