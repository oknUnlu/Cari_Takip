using CariTakip.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariTakip
{
    public class Database
    {
        private static ISessionFactory _sessionfactory;
        private const string SessionKey = "CariTakip.Database.SessionKey";
        public static void Configure() {
            var config = new Configuration();
            config.Configure();

            var mapper = new ModelMapper();
            mapper.AddMapping<MusteriMap>();
            mapper.AddMapping<TurMap>();
            mapper.AddMapping<OdemeSekliMap>();
            mapper.AddMapping<CariHesapMap>();
            mapper.AddMapping<RolMap>();
            mapper.AddMapping<KullaniciMap>();


            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            _sessionfactory = config.BuildSessionFactory();
        }
        public static ISession Session
        {
            get
            {
                return (ISession)HttpContext.Current.Items[SessionKey];
            }
        }
        public static void OpenSession() {

            HttpContext.Current.Items[SessionKey] = _sessionfactory.OpenSession();
        }
        public static void CloseSession() {
            var session = HttpContext.Current.Items[SessionKey] as ISession;

            if (session != null)
            {
                session.Close();

            }
            HttpContext.Current.Items.Remove(SessionKey);
        }
    }
}