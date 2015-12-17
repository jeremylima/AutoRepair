using System;

namespace AutoRepair.DataAccess.Infrastructure
{
	public interface IUnitOfWork : IDisposable
	{
		void Commit();
		void Rollback();
	}
}