using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UStart.Domain.Contracts.Entities;
using UStart.Domain.Contracts.Repositories;
using UStart.Domain.Entities;
using UStart.Domain.Results;
using UStart.Infrastructure.Context;

namespace UStart.Infrastructure.Repositories
{

    public class ImovelRepository : IImovelRepository
    {
        private readonly UStartContext _context;

        public ImovelRepository(UStartContext context)
        {
            _context = context;
        }

        public Imovel ConsultarPorId(Guid id)
        {
            return _context.Imoveis
                .FirstOrDefault(u => u.Id == id);
        }

        public void Add(Imovel Imovel)
        {
            _context.Imoveis.Add(Imovel);
        }

        public void Update(Imovel Imovel)
        {
            _context.Imoveis.Update(Imovel);
        }

        public virtual void Delete(Imovel Imovel)
        {
            if (_context.Entry(Imovel).State == EntityState.Detached)
            {
                _context.Imoveis.Attach(Imovel);
            }
            _context.Imoveis.Remove(Imovel);
        }
        public IEnumerable<Imovel> Pesquisar(string pesquisa)
        {
            pesquisa = pesquisa != null ? pesquisa.ToLower() : "";
            return _context
            .Imoveis
            .Where(x =>x.TipoImovel.ToLower().Contains(pesquisa)
            ||x.Finalidade.ToLower().Contains(pesquisa))
            .ToList();
        }
        public IEnumerable<Imovel> RetornarTodos()
        {
            return _context
                .Imoveis
                .ToList();
        }
        // public ImovelResult GetImovelResultPorId(Guid id)
        // {
        //     Imovel imovel = _context
        //         .Imoveis
        //         .Include(c => c.Cliente)
        //             .ThenInclude(p => p.Nome)
        //         .Include(u => u.Usuario)
        //         .FirstOrDefault(u => u.Id == id);
        //     if (imovel == null)
        //     {
        //         return null;
        //     }
        //     return new ImovelResult(imovel);
        // }
        

    }
}
