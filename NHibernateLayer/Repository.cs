using System;
using NHibernate;
using System.Linq;
using NHibernate.Linq;
using AutoRepair.DataAccess.Infrastructure;
using Microsoft.Win32;

namespace AutoRepair.DataAccess.NHibernate
{
    public class Repository<T> : NHibernateContext, IIntKeyedRepository<T> where T : class
    {
        //private ISessionFactory _sessionFactory;
       

        public Repository(ISessionFactory sessionFactory)
        {
            //_sessionFactory = sessionFactory;

            if (!SessionHandler.IsOpen)
                SessionHandler.OpenSession(sessionFactory);


        }

        #region IRepository<T> Members

        public bool Add(T entity)
        {
            //var session = _sessionFactory.IsClosed ? _sessionFactory.OpenSession() : _sessionFactory.GetCurrentSession();

            //ISession session = _sessionFactory.OpenSession();
            ISession session = SessionHandler.GetSession();

            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
                session.Close();
            }

            return true;
        }

        public bool Add(System.Collections.Generic.IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                //_sessionFactory.OpenSession().Save(item);
                SessionHandler.GetSession().Save(item);
            }
            return true;
        }

        public bool Update(T entity)
        {
            SessionHandler.Update(entity);

            //ISession session = _sessionFactory.OpenSession();
            //var session = _sessionFactory.IsClosed ? _sessionFactory.OpenSession() : _sessionFactory.GetCurrentSession();
           /* ISession session = SessionHandler.GetSession();

            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
               
            }*/

           return true;
        }

        public bool Delete(T entity)
        {
            try
            {
                //ISession session = _sessionFactory.OpenSession();

                //ISession session = SessionHandler.GetSession();

                /*if (NHibernate.Context.CurrentSessionContext.HasBind(sessionFactory))
                {
                    session = sessionFactory.GetCurrentSession();
                }
                else
                {
                    session = sessionFactory.OpenSession(this.dateTimeInterceptor);
                    NHibernate.Context.CurrentSessionContext.Bind(session);
                }*/

                /*using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                    
                }*/
                /*SessionHandler.GetSession().Clear();
                SessionHandler.GetSession().Delete(entity);
                SessionHandler.GetSession().Flush();*/
                SessionHandler.Detele(entity);

                return true;
            }
            catch (Exception exception)
            {
                return false;

            }
            
        }

        public bool Delete(System.Collections.Generic.IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                //_sessionFactory.OpenSession().Delete(entity);
                SessionHandler.GetSession().Delete(entity);
            }
            return true;
        }

        #endregion

        #region IIntKeyedRepository<T> Members

        public T FindBy(int id)
        {
            //return _sessionFactory.OpenSession().Get<T>(id);
            return SessionHandler.GetSession().Get<T>(id);
        }

        #endregion

        #region IReadOnlyRepository<T> Members

        public IQueryable<T> All()
        {
            //return _sessionFactory.OpenSession().Query<T>();
            return SessionHandler.GetSession().Query<T>();

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