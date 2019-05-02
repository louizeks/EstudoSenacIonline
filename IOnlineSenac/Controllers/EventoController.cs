using IOnlineSenac.Application.Interfaces;
using IOnlineSenac.DTO.Evento;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOnlineSenac.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        readonly IEventoApplication _eventoApplication;

        public EventoController(IEventoApplication eventoApplication)
        {
            _eventoApplication = eventoApplication;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(typeof(List<ObterEventosResponse>))]
        public ActionResult<ObterEventosResponse> Get()
        {
            if (ModelState.IsValid)
            {
                var acessoResponse = _eventoApplication.ObterEventos();

                return Ok(acessoResponse);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }

}
