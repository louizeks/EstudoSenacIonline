
using IOnlineSenac.Application.Interfaces;
using IOnlineSenac.DTO.Acesso;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace IOnlineSenac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        readonly IAcessoApplication _acessoApplication;

        public AcessoController(IAcessoApplication acessoApplication)
        {
            _acessoApplication = acessoApplication;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ValidaAcessoResponse> Get([FromQuery]ValidaAcessoRequest request)
        {
            if (ModelState.IsValid)
            {
                var acessoResponse = _acessoApplication.ValidarAcesso(request);

                return Ok(acessoResponse);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
