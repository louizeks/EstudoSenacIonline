using IOnlineSenac.DTO.Evento;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Application.Interfaces
{
    public interface IEventoApplication
    {
        List<ObterEventosResponse> ObterEventos();
    }
}
