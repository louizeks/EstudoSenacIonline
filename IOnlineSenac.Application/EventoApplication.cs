using IOnlineSenac.Application.Interfaces;
using IOnlineSenac.DTO.Evento;
using IOnlineSenac.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOnlineSenac.Application
{
    public class EventoApplication : IEventoApplication
    {
        readonly IEventoService _eventoService;


        public EventoApplication(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        public List<ObterEventosResponse> ObterEventos()
        {
            var response = new List<ObterEventosResponse>();

            var listaEventos = _eventoService.ObterEventos();

            listaEventos.ForEach(x =>
            {
                response.Add(new ObterEventosResponse
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    Banner = x.Banner,
                    DataEvento = x.DataEvento,
                    Descricao = x.Descricao,
                    Destaque = x.Destaque
                });
            });

            return response;
        }
    }
}
