﻿using System;

namespace AutoRepair.DataAccess.Infrastructure
{
	public interface IGuidKeyedRepository<TEntity> : IRepository<TEntity> where TEntity:class 
	{
		TEntity FindBy(Guid id);
	}
}