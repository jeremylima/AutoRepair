using System;
using System.Collections.Generic;

namespace AutoRepair.DataAccess.Infrastructure
{
	public interface IRepository<TEntity> : IReadOnlyRepository<TEntity>, IDisposable where TEntity:class
	{
		bool Add(TEntity entity);
		bool Add(IEnumerable<TEntity> items);
		bool Update(TEntity entity);
		bool Delete(TEntity entity);
		bool Delete(IEnumerable<TEntity> entities);
	}
}
