namespace Twenty2.Schedule.Api.Repositories;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Entities;

public abstract class SkeletalRepository<TEntity> : IRepository<long, TEntity> where TEntity : class, IEntity
{
    public DbContext DbContext { get; private set; }

    public SkeletalRepository( DbContext dbContext )
    {
        DbContext = dbContext;
    }

    public Task<bool> Delete( TEntity entity )
    {
        return Task.FromResult( DbContext.Remove( entity ).State == EntityState.Deleted );
    }

    public async Task<TEntity> Add( TEntity entity )
    {
        return ( await DbContext.AddAsync( entity ) ).Entity;
    }

    public async Task<bool> SaveChanges()
    {
        return ( await DbContext.SaveChangesAsync() ) > 0;
    }

    public Task<TEntity> Update( TEntity entity )
    {
        var existingEntity = DbContext.Find<TEntity>( entity.Id );

        if ( existingEntity == null )
        {
            return Task.FromException<TEntity>( new ArgumentException() );
        }

        DbContext.Entry( existingEntity ).CurrentValues.SetValues( entity );
        return Task.FromResult( existingEntity );
    }

    public Task<IEnumerable<TEntity>> GetAll()
    {
        return Task.FromResult( DbContext.Set<TEntity>().AsEnumerable() );
    }

    public Task<TEntity?> Get( long id )
    {
        return Task.FromResult( DbContext.Find<TEntity>( id ) );
    }
}

