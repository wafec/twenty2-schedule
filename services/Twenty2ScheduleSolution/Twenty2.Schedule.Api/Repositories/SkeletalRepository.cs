namespace Twenty2.Schedule.Api.Repositories;

using Microsoft.EntityFrameworkCore;
using Twenty2.Schedule.Api.Entities;

public abstract class SkeletalRepository<TEntity> : IRepository<long, TEntity> where TEntity : class, IEntity
{
    public DbContext DbContext { get; private set; }

    public SkeletalRepository( DbContext dbContext )
    {
        DbContext = dbContext;
    }

    public Task<bool> Delete( long id )
    {
        var entity = DbContext.Find<TEntity>( id );
        if ( entity == null )
        {
            return Task.FromResult( false );
        }
        var result = DbContext.Remove( entity );
        return Task.FromResult( result.State == EntityState.Deleted );
    }

    public async Task<TEntity> Add( TEntity entity )
    {
        var result = await DbContext.AddAsync( entity );
        return (TEntity)result.Entity;
    }

    public async Task<bool> SaveChanges()
    {
        var result = await DbContext.SaveChangesAsync();
        return result > 0;
    }

    public Task<TEntity> Update( TEntity entity )
    {
        var result = DbContext.Update( entity );
        return Task.FromResult( (TEntity) result.Entity );
    }
}

