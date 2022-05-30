using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Entities;

public abstract class BaseEntity
{
    [BsonId]
    public Guid Id { get; private set; }

    public DateTimeOffset Created { get; private set; }

    public DateTimeOffset? Updated { get; protected set; }
    
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        Created = DateTimeOffset.UtcNow;
    }
}
