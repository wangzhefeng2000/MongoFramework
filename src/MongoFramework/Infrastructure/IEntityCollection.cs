﻿using System.Collections.Generic;

namespace MongoFramework.Infrastructure
{
	public interface IEntityCollectionBase<TEntity> where TEntity : class
	{
		EntityEntry<TEntity> GetEntry(TEntity entity);
		IEnumerable<EntityEntry<TEntity>> GetEntries();
		void Update(TEntity entity, EntityEntryState state);
		bool Remove(TEntity entity);
	}

	public interface IEntityCollection<TEntity> : IEntityCollectionBase<TEntity>, ICollection<TEntity> where TEntity : class
	{

	}
}
