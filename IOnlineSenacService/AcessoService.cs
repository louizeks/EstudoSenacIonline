
using IOnlineSenac.Data.Context.Interfaces;
using IOnlineSenac.Domain.Entities;
using IOnlineSenac.Service.Interfaces;
using System;

namespace IOnlineSenac.Service
{
    public class AcessoService : IAcessoService
    {
        readonly IUnitOfWork _unitOfWork;

        public AcessoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool ValidarAcesso(Guid idUsuario, Guid IdEvento)
        {
            return _unitOfWork.AcessoRepository.ValidarAcesso(idUsuario, IdEvento);
        }
    }
}
