using KindergartenApp.Options;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KindergartenApp.Infrastructure;

public class Repository : IRepository
{
    private readonly DbContext _context;

    public Repository(IOptions<Settings> settings)
    {
        _context = new DbContext(settings);
    }
    
    public async Task Add<TEntity>(TEntity entity, string nameCollection)
    {
        await _context.Entities<TEntity>(nameCollection).InsertOneAsync(entity);
    }

    public async Task<TEntity> Get<TEntity>(string id, string nameCollection)
    {
        var filter = Builders<TEntity>.Filter.Eq("Id", id);
        return await _context.Entities<TEntity>(nameCollection)
            .Find(filter)
            .FirstOrDefaultAsync();
    }

    public async Task Update<TEntity>(string id, TEntity entity, string nameCollection)
    {
        await Remove<TEntity>(id, nameCollection);
        await Add(entity, nameCollection);
    }

    public async Task<DeleteResult> Remove<TEntity>(string id, string nameCollection)
    {
        return await _context.Entities<TEntity>(nameCollection).DeleteOneAsync(
            Builders<TEntity>.Filter.Eq("Id", id));
    }

    public async Task<IEnumerable<TEntity>> GetAll<TEntity>(string nameCollection)
    {
        return await _context.Entities<TEntity>(nameCollection).Find(_ => true).ToListAsync();
    }
}