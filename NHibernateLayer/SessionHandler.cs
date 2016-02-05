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

        public static void Merge(object entity)
        {
            Clear();
            Session.Merge(entity);
            Flush();
        }

        public static void Detele(object entity)
        {
            Clear();
            Session.Delete(entity);
            Flush();
        }

        public static void Add(object entity)
        {
            Clear();
            Session.Save(entity);
            Flush();
        }

        public static int AddAndReturnIdCreated(object entity)
        {
            Clear();
            var obj = Session.Save(entity);
            Flush();
            return (int) obj;
        }
    }
}