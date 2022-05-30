using KindergartenApp.Options;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KindergartenApp.Infrastructure;

public class DbContext
{
    private readonly IMongoDatabase? _database = null;
    
    public DbContext(IOptions<Settings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString) ?? null;
        
        if (client != null)
            _database = client.GetDatabase(settings.Value.Database);
    }
    
    public IMongoCollection<TEntity> Entities<TEntity>(string nameCollection) => 
        _database!.GetCollection<TEntity>(nameCollection);
}