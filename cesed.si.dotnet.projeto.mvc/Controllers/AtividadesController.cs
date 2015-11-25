using AutoMapper;
using cesed.si.dotnet.projeto.aplicacao.Interfaces;
using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.mvc.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cesed.si.dotnet.projeto.mvc.Controllers
{
    public class AtividadesController : Controller
    {
        private readonly IAtividadeAppService _atividadeAppService;
        private readonly IUsuarioAppService _usuarioAppService;

        public AtividadesController(IAtividadeAppService atividadeAppService, IUsuarioAppService usuarioAppService)
        {
            _atividadeAppService = atividadeAppService;
            _usuarioAppService = usuarioAppService;
        }

        // GET: Atividade
        public ActionResult Index()
        {
            Mapper.CreateMap<Atividade, AtividadeViewModel>();
            var atividadeViewModel = Mapper.Map<IEnumerable<Atividade>, IEnumerable<AtividadeViewModel>>(_atividadeAppService.GetAll());
            return View(atividadeViewModel);
        }

        // GET: Atividade/Details/5
        public ActionResult Details(int id)
        {
            var atividade = _atividadeAppService.GetById(id);
            var atividadeViewModel = Mapper.Map<Atividade, AtividadeViewModel>(atividade);
            return View(atividadeViewModel);
        }

        // GET: Atividade/Create
        public ActionResult Create()
        {
            ViewBag.UsuarioId = new SelectList(_usuarioAppService.GetAll(), "UsuarioId", "UsuarioNome");
            return View();
        }

        // POST: Atividade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AtividadeViewModel atividade)
        {
            if (ModelState.IsValid)
            {
                var atividadeDomain = Mapper.Map<AtividadeViewModel, Atividade>(atividade);
                _atividadeAppService.Add(atividadeDomain);
                return RedirectToAction("Index");
            }
            return View(atividade);
        }

        // GET: Atividade/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.UsuarioId = new SelectList(_usuarioAppService.GetAll(), "UsuarioId", "UsuarioNome");
            var atividade = _atividadeAppService.GetById(id);
            var atividadeViewModel = Mapper.Map<Atividade, AtividadeViewModel>(atividade);
            return View(atividadeViewModel);
        }

        // POST: Atividade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AtividadeViewModel atividade)
        {
            if (ModelState.IsValid)
            {
                var atividadeDomain = Mapper.Map<AtividadeViewModel, Atividade>(atividade);
                _atividadeAppService.Update(atividadeDomain);
                return RedirectToAction("Index");
            }
            return View(atividade);
        }

        // GET: Atividade/Delete/5
        public ActionResult Delete(int id)
        {
            var atividade = _atividadeAppService.GetById(id);
            var atividadeViewModel = Mapper.Map<Atividade, AtividadeViewModel>(atividade);
            return View(atividadeViewModel);
        }

        // POST: Atividade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfitmed(int id)
        {
            var atividade = _atividadeAppService.GetById(id);
            _atividadeAppService.Remove(atividade);
            return RedirectToAction("Index");
        }
    }
    
}