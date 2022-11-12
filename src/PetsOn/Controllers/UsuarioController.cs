﻿using Microsoft.AspNetCore.Mvc;
using PetsOn.Domain.Entities;
using PetsOn.Models;
using PetsOn.Repository.DAL;
using PetsOn.Services.Interfaces;

namespace PetsOn.Controllers
{
    public class UsuarioController : Controller
    {
        readonly IServiceAplicationUsuario ServiceAplicationUsuario;

        public UsuarioController(IServiceAplicationUsuario serviceAplicationUsuario)
        {
            ServiceAplicationUsuario = serviceAplicationUsuario;
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioPetshopViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServiceAplicationUsuario.Cadastrar(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }
    }
}