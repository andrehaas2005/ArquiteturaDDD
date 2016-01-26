﻿

using System.Collections.Generic;
using System.Linq;
using ArquiteturaDDD.Domain.Entities;
using ArquiteturaDDD.Domain.Interfaces.Repositories;
using ArquiteturaDDD.Domain.Interfaces.Services;

namespace ArquiteturaDDD.Domain.Services
{
   public class ClienteService : ServiceBase<Cliente> , IClienteService
   {
       private readonly IClienteRepository _clienteRepository;

       public ClienteService(IClienteRepository clienteRepository)
           : base(clienteRepository)
       {
           _clienteRepository = clienteRepository;
       }

       public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
       {
           return clientes.Where(c => c.ClienteEspecial(c));
       }
   }
}
