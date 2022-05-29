using MongoDB.Driver;

namespace KindergartenApp.Infrastructure;

public interface IRepository
{
    public Task Add<TEntity>(TEntity entity, string nameCollection); // Create
    public Task<TEntity> Get<TEntity>(string id, string nameCollection); // Read
    public Task Update<TEntity>(string id, TEntity entity, string nameCollection); // Update
    public Task<DeleteResult> Remove<TEntity>(string id, string nameCollection); // Delete
    public Task<IEnumerable<TEntity>> GetAll<TEntity>(string nameCollection); // Read All
}