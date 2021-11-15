using System;
using UStart.Domain.Commands;
using UStart.Domain.Contracts.Repositories;
using UStart.Domain.Entities;
using UStart.Domain.UoW;

namespace UStart.Domain.Workflows
{
    public class ImovelWorkflow : WorkflowBase
    {
        private readonly IImovelRepository _imovelRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ImovelWorkflow(IImovelRepository imovelRepository, IUnitOfWork unitOfWork)
        {
            _imovelRepository = imovelRepository;
            _unitOfWork = unitOfWork;
        }

        public Imovel Add(ImovelCommand command)
        {
            var novoImovel = new Imovel(command);
           _imovelRepository.Add(novoImovel);
            _unitOfWork.Commit();

            return novoImovel;
        }

        public void Update(Guid id, ImovelCommand command)
        {
            var imovel = _imovelRepository.ConsultarPorId(id);
            if (imovel != null)
            {
                imovel.Update(command);
                _imovelRepository.Update(imovel);
                _unitOfWork.Commit();
            }
            else
            {
                AddError("Imovel", "Imovel não encontrado", id);
            }
        }

        public void Delete(Guid id)
        {
            try
            {

                var imovel = _imovelRepository.ConsultarPorId(id);
                if (imovel == null)
                {
                    AddError("imovel", "Dados de imovel não encontrado", id);
                }
                if (!IsValid())
                {
                    return;
                }

                _imovelRepository.Delete(imovel);
                _unitOfWork.Commit();
            }
            catch (System.Exception exp)
            {
                if (this.isDevelopment())
                    AddException("Imovel", exp);
                else throw;
            }
        }
    }
}