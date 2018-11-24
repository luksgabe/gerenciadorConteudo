using ProjectDomain.Interfaces.Repositories;
using System.Web;

namespace ProjectDomain.Services.Specific
{
    public class SessionService
    {
        protected static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }

        protected static T ReadToDefault<T>(string sessionName)
        {
            object valor = HttpContext.Current.Session[sessionName];
            return valor == null ? default(T) : ((T)valor);
        }

        protected static T Red<T>(string sessionName)
        {
            return (T)HttpContext.Current.Session[sessionName];
        }

        protected static void RemoveAll()
        {
            HttpContext.Current.Session.RemoveAll();
        }

        protected static void Update(string sessionName, object value)
        {
            HttpContext.Current.Session[sessionName] = value;
        }
    }
}
