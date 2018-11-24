using Project.Aplication.Interface;
using ProjectDomain.Services.Specific;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCProject.Controllers.Controle
{
    
    public class BaseController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public BaseController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var data = _usuarioApp.GetById((int)SessionControl.Id);
            if (data != null)
            {
                //comandos futuros
            }

        }
    }
}