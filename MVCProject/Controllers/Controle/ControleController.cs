using AutoMapper;
using MVCProject.ViewModels;
using Project.Aplication.Interface;
using ProjectDomain.Entities;
using Project.Libraries;
using ProjectDomain.Services.Specific;
using System;
using System.Web.Mvc;

namespace MVCProject.Controllers.Controle
{
    public class ControleController : BaseController
    {
        
        private readonly IUsuarioAppService _usuarioApp;

        public ControleController(IUsuarioAppService usuarioApp) : base(usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Controle
        public ActionResult Index()
        {
            return View();
        }

        // POST: Controle
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userDomain = Mapper.Map<UsuarioViewModel, Usuario>(model);
                    userDomain = _usuarioApp.BuscaLogin(userDomain);
                    SessionControl.InsertSession(userDomain);
                    return RedirectToAction("Home", "Controle");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        [@Authorize]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [@Authorize]
        public ActionResult Configuracoes()
        {
            return View();
        }

        public ActionResult Sair()
        {
            SessionControl.EndSession();
            return RedirectToAction("Index");
        }
    }
}