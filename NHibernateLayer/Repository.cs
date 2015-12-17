using NHibernate;
using System.Linq;
using NHibernate.Linq;
using AutoRepair.DataAccess.Infrastructure;

namespace AutoRepair.DataAccess.NHibernate
{
    public class Repository<T> : NHibernateContext, IIntKeyedRepository<T> where T : class
    {
        private ISessionFactory _sessionFactory;

        public Repository(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        #region IRepository<T> Members

        public bool Add(T entity)
        {
            ISession session = _sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }

            return true;
        }

        public bool Add(System.Collections.Generic.IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                _sessionFactory.OpenSession().Save(item);
            }
            return true;
        }

        public bool Update(T entity)
        {
            ISession session = _sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
            }
            
            return true;
        }

        public bool Delete(T entity)
        {
            ISession session = _sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(entity);
                transaction.Commit();
            }

            return true;
        }

        public bool Delete(System.Collections.Generic.IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                _sessionFactory.OpenSession().Delete(entity);
            }
            return true;
        }

        #endregion

        #region IIntKeyedRepository<T> Members

        public T FindBy(int id)
        {
            return _sessionFactory.OpenSession().Get<T>(id);
        }

        #endregion

        #region IReadOnlyRepository<T> Members

        public IQueryable<T> All()
        {
            return _sessionFactory.OpenSession().Linq<T>();
            
        }

        public T FindBy(System.Linq.Expressions.Expression<System.Func<T, bool>> expression)
        {
            return FilterBy(expression).Single();
        }

        public IQueryable<T> FilterBy(System.Linq.Expressions.Expression<System.Func<T, bool>> expression)
        {
            return All().Where(expression).AsQueryable();
        }

        #endregion


    }
}