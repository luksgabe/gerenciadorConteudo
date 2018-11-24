using ProjectDomain.Services.Specific;
using System.Web;
using System.Web.Mvc;

namespace Project.Libraries
{
    public class Authorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (SessionControl.CheckSession(SessionControl.UserName) == true)
                return true;
            else
                return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (SessionControl.CheckSession(SessionControl.UserName) == false)
            {
                filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary
                    {
                            {"action", "Index" },
                            {"controller", "Controle" }
                    });
            }
            else
                base.HandleUnauthorizedRequest(filterContext);
        }
    }
}
