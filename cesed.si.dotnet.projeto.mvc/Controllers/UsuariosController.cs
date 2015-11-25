﻿using AutoMapper;
using cesed.si.dotnet.projeto.aplicacao.Interfaces;
using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.mvc.ViewsModels;
using System.Collections.Generic;
using System.Web.Mvc;


namespace cesed.si.dotnet.projeto.mvc.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public UsuariosController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioApp.GetAll());
            return View(usuarioViewModel);

        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Add(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioApp.Update(usuarioDomain);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);
            return View(usuarioViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioApp.GetById(id);
            _usuarioApp.Remove(usuario);

            return RedirectToAction("Index");
        }
    }
}
