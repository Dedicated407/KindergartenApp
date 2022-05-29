using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Entities;

public class JunctionTable
{
    [BsonId]
    public Guid Id { get; set; }
    
    public Guid ChildId { get; set; }
    
    public Guid VaccinationId { get; set; }
}