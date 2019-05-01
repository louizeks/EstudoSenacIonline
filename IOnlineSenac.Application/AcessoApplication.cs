using IOnlineSenac.Application.Interfaces;
using IOnlineSenac.DTO.Acesso;
using IOnlineSenac.Service.Interfaces;
using System;

namespace IOnlineSenac.Application
{
    public class AcessoApplication : IAcessoApplication
    {
        readonly IAcessoService _acessoService;
        readonly IUsuarioService _usuarioService;


        public AcessoApplication(IAcessoService acessoService, IUsuarioService usuarioService)
        {
            _acessoService = acessoService;
            _usuarioService = usuarioService;
        }

        public ValidaAcessoResponse ValidarAcesso(ValidaAcessoRequest request)
        {
            ValidaAcessoResponse response = new ValidaAcessoResponse();
            response.PodeAcessar = false;

            var usuario = _usuarioService.ObterPorId(request.IdUsuario);
            if (usuario == null)
            {
                response.Erro = true;
                response.Mensagem = "Usuário não encontrado";
                return response;
            }

            response.UsuarioId = usuario.Id;
            response.Nome = usuario.Nome;
            response.Email = usuario.Email;
            response.DataNascimento = usuario.DataNascimento;
            response.PodeAcessar = _acessoService.ValidarAcesso(request.IdUsuario, request.IdEvento);

            return response;
        }
    }
}
