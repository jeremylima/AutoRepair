using System;
using System.Collections.Generic;
using NHibernate;
using System.Linq;
using NHibernate.Linq;
using AutoRepair.DataAccess.Infrastructure;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using NHibernate.Exceptions;

namespace AutoRepair.DataAccess.NHibernate
{
    public class Repository<T> : NHibernateContext, IIntKeyedRepository<T> where T : class
    {

        public Repository(ISessionFactory sessionFactory)
        {
            if (!SessionHandler.IsOpen)
                SessionHandler.OpenSession(sessionFactory);
        }

        #region IRepository<T> Members

        public bool Add(T entity)
        {
            SessionHandler.Add(entity);

            return true;
        }

        public int AddAndReturnIdCreated(T entity)
        {
            return SessionHandler.AddAndReturnIdCreated(entity);
        }

        public bool Add(System.Collections.Generic.IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                SessionHandler.GetSession().Save(item);
            }
            return true;
        }

        public bool Update(T entity)
        {
            SessionHandler.Update(entity);

           return true;
        }

        public bool Update(IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                SessionHandler.Update(entity);
            }
            
            return true;
        }

        public bool Delete(T entity)
        {
            try
            {
                SessionHandler.Detele(entity);

                return true;
            }
            catch (GenericADOException exception)
            {

                var sql = exception.InnerException as MySqlException;
                if (sql != null && sql.Number == 1451)
                {
                    throw new Exception("No puede eliminar el registro, porque tiene datos relacionados.");
                }
                return false;
            }
            
        }

        public bool Delete(System.Collections.Generic.IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                SessionHandler.Detele(entity); ;
            }
            return true;
        }

        #endregion

        #region IIntKeyedRepository<T> Members

        public T FindBy(int id)
        {
            SessionHandler.Clear();
            return SessionHandler.GetSession().Get<T>(id);
        }

        #endregion

        #region IReadOnlyRepository<T> Members

        public IQueryable<T> All()
        {
            SessionHandler.Clear();
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