using MongoDB.Driver;

namespace KindergartenApp.Infrastructure;

public interface IRepository
{
    public Task Add<TEntity>(TEntity entity, string nameCollection); // Create
    public Task<TEntity> Get<TEntity>(Guid id, string nameCollection); // Read
    public Task Update<TEntity>(Guid id, TEntity entity, string nameCollection); // Update
    public Task<DeleteResult> Remove<TEntity>(Guid id, string nameCollection); // Delete
    public Task<IEnumerable<TEntity>> GetAll<TEntity>(string nameCollection); // Read All
}