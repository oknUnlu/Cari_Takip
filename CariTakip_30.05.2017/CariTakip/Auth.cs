using CariTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Linq;
namespace CariTakip
{
    public static class Auth
    {
        private const string Userkey = "CariTakip.Auth.UserKey";

        public static Kullanici Kullanici
        {
            get
            {
                if (!HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    return null;
                }
                var kullanici = HttpContext.Current.Items[Userkey] as Kullanici;
                if (kullanici == null)
                {
                    kullanici = Database.Session.Query<Kullanici>().FirstOrDefault(x => x.Adi == HttpContext.Current.User.Identity.Name);
                    if (kullanici == null)
                    {
                        return null;
                    }
                    HttpContext.Current.Items[Userkey] = kullanici;
                }
                return kullanici;
            }
        }
    }
}