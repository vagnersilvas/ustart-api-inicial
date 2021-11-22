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

            if (validarImovel(command) == false)
            {
                return null;
            }

            var novoImovel = new Imovel(command);
            _imovelRepository.Add(novoImovel);
            _unitOfWork.Commit();

            return novoImovel;
        }

        public void Update(Guid id, ImovelCommand command)
        {

            if (validarImovel(command) == false)
            {
                return;
            }

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

        private bool validarImovel(ImovelCommand command)
        {
            if (string.IsNullOrEmpty(command.TipoImovel))
            {
                this.AddError("Tipo do imovel", "Tipo do imovel não informado");
            }
            if (command.ClienteId == Guid.Empty)
            {
                this.AddError("Cliente", "Cliente não informado");
            }

            return this.IsValid();

        }
    }
}