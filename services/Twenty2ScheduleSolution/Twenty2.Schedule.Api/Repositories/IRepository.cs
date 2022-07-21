namespace Twenty2.Schedule.Api.Repositories;

public interface IRepository<TKey, TEntity>
{
    Task<TEntity> Add( TEntity entity );

    Task<TEntity> Update( TEntity entity );

    Task<bool> Delete( TEntity entity );

    Task<bool> SaveChanges();

    Task<IEnumerable<TEntity>> GetAll();

    Task<TEntity?> Get( TKey id );
}

