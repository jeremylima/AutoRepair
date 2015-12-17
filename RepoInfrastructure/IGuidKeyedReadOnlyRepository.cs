using System;

namespace AutoRepair.DataAccess.Infrastructure
{
	public interface IGuidKeyedReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity:class
	{
		TEntity FindBy(Guid id);
	}
}