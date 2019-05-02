using IOnlineSenac.Data.Context.Interfaces;
using IOnlineSenac.Domain.Entities;
using IOnlineSenac.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Service
{
    public class EventoService : IEventoService
    {
        readonly IUnitOfWork _unitOfWork;

        public EventoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Evento> ObterEventos()
        {
            return _unitOfWork.EventoRepository.ObterEventos();
        }
    }
}
