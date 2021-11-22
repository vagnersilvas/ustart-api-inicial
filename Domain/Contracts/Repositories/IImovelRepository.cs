using System;
using System.Collections.Generic;
using UStart.Domain.Entities;
using UStart.Domain.Results;

namespace UStart.Domain.Contracts.Repositories
{
    public interface IImovelRepository
    {
        void Add(Imovel Imovel);
        Imovel ConsultarPorId(Guid id);
        ImovelResult GetOrcamentoResultPorId(Guid id);
        IEnumerable<Imovel> RetornarTodos();
        IEnumerable<ImovelResult> Pesquisar(string pesquisa);
        void Update(Imovel Imovel);
        void Delete(Imovel Imovel);
    }

}