using Microsoft.AspNetCore.Mvc;
using Odontoprev.Domain;
using Odontoprev.DTOs;
using Odontoprev.Services;

namespace Odontoprev.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Login(string cpf, string senha)
        {
            try
            {
                var usuario = _usuarioService.Login(cpf, senha);
                return Ok(usuario);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UploadFoto(int usuarioId, string caminhoFoto)
        {
            try
            {
                _usuarioService.UploadFoto(usuarioId, caminhoFoto);
                return Ok("Foto enviada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(UsuarioDto usuarioDto)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Nome = usuarioDto.Nome,
                    Cpf = usuarioDto.Cpf,
                    Senha = usuarioDto.Senha,  // Se o DTO incluir a senha
                    DataCriacao = DateTime.Now

                };
                _usuarioService.Add(usuario);
                return Ok("Usuário criado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

