using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UStart.Domain.Contracts.Repositories;
using UStart.Domain.Entities;
using UStart.Infrastructure.Context;

namespace UStart.Infrastructure.Repositories
{


    public class ClienteRepository : IClienteRepository
    {
        private readonly UStartContext _context;

        public ClienteRepository(UStartContext context)
        {
            _context = context;
        }

        public Cliente ConsultarPorId(Guid id)
        {
            return _context.Clientes.FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Cliente> Pesquisar(string pesquisa)
        {
            pesquisa = pesquisa != null ? pesquisa.ToLower() : string.Empty;

            return _context
            .Clientes
            .Where(x => x.Nome.ToLower().Contains(pesquisa))
            .ToList();
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }

        public void Delete(Cliente cliente)
        {
            if (_context.Entry(cliente).State == EntityState.Detached)
            {
                _context.Clientes.Attach(cliente);
            }
            _context.Clientes.Remove(cliente);
        }
    }
}