using NHibernate;

namespace AutoRepair.DataAccess.NHibernate
{
    public class SessionHandler
    {
        private static ISession Session { get; set; }

        public static bool IsOpen { get; set; }

        public static void OpenSession(ISessionFactory sessionFactory)
        {
            Session = sessionFactory.OpenSession();
        }

        public static ISession GetSession()
        {
            return Session;
        }

        public static void Clear()
        {
            Session.Clear();
        }

        public static void Flush()
        {
            Session.Flush();
        }

        public static void Update(object entity)
        {
            Clear();
            Session.Update(entity);
            Flush();
        }

        public static void Detele(object entity)
        {
            Clear();
            Session.Delete(entity);
            Flush();
        }
    }
}