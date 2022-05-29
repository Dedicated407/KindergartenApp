using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Models;

public abstract class BaseEntity
{
    [BsonId]
    public string Id { get; set; }

    public DateTimeOffset Created { get; private set; }

    public DateTimeOffset? Updated { get; protected set; }
    
    protected BaseEntity()
    {
        Created = DateTimeOffset.UtcNow;
    }
}
