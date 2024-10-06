using Microsoft.AspNetCore.Mvc;
using Odontoprev.Domain;
using Odontoprev.DTOs;
using Odontoprev.Services;
using System;

namespace Odontoprev.Controllers
{
    public class CreateController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public CreateController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }


        [HttpPost]
        public IActionResult CreateUser(UsuarioDto usuarioDto)
        {

            if (!ModelState.IsValid)
            {
                return View(usuarioDto);
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    Nome = usuarioDto.Nome,
                    Cpf = usuarioDto.Cpf,
                    Senha = usuarioDto.Senha,
                    DataCriacao = DateTime.Now
                };

                _usuarioService.Add(usuario);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Erro ao criar usuário: {ex.Message}");
                return View(usuarioDto);
            }
        }
    }
}
