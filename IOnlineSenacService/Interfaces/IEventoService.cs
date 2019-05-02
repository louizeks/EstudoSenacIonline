using IOnlineSenac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Service.Interfaces
{
    public interface IEventoService
    {
        List<Evento> ObterEventos();
    }
}
