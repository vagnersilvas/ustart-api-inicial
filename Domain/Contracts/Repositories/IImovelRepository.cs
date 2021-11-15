using System;
using System.Collections.Generic;
using UStart.Domain.Entities;

namespace UStart.Domain.Contracts.Repositories
{
    public interface IImovelRepository
    {
        void Add(Imovel Imovel);
        Imovel ConsultarPorId(Guid id);
        void Delete(Imovel Imovel);
        IEnumerable<Imovel> Pesquisar(string pesquisa);
        IEnumerable<Imovel> RetornarTodos();
        void Update(Imovel Imovel);
    }

}