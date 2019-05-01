using IOnlineSenac.Data.Context.Interfaces;
using IOnlineSenac.Domain.Entities;
using IOnlineSenac.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Service
{
    public class UsuarioService : IUsuarioService
    {
        readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    
        public Usuario ObterPorId(Guid id)
        {
            return _unitOfWork.UsuarioRepository.ObterPorId(id);
        }
    }
}
