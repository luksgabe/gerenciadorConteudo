using ProjectDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDomain.Services.Specific
{
    public class SessionControl : SessionService
    {
        private const string UserSessionName = "Session do Nome de Usuario";
        private const string UserSessionId = "Session do Id de Usuario";


        public static string UserName
        {
            get
            {
                return ReadToDefault<string>(UserSessionName);
            }
            set
            {
                Update(UserSessionName, value);
            }
        }
        public static long Id
        {
            get
            {
                return ReadToDefault<Int64>(UserSessionId);
            }
            set
            {
                Update(UserSessionId, value);
            }
        }

        public static void InsertSession(Usuario usuario)
        {
            Id = Convert.ToInt64(usuario.id);
            UserName = usuario.nome;
        }

        public static void UpdateSession(string sessionName, object value)
        {
            Update(sessionName, value);
        }

        public static void EndSession()
        {
            RemoveAll();
        }

        public static bool CheckSession(string chave)
        {
            if (!string.IsNullOrEmpty(chave))
                return true;
            else
                return false;
        }

        public static bool CheckSession(HttpContextBase contexto)
        {
            if (contexto.Session["UserSessionName"] != null)
                return true;
            else
                return false;
        }
    }
}
