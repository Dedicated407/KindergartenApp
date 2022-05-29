using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Models;

public abstract class BaseEntity
{
    [BsonId]
    public ObjectId Id { get; private set; }

    public DateTimeOffset Created { get; private set; }

    public DateTimeOffset? Updated { get; protected set; }
    
    protected BaseEntity()
    {
        Id = ObjectId.GenerateNewId();
        Created = DateTimeOffset.UtcNow;
    }
}
