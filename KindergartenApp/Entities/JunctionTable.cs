using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Models;

public class JunctionTable
{
    [BsonId]
    public string Id { get; set; }
    
    [BsonId]
    public string ChildId { get; set; }
    
    [BsonId]
    public string VaccinationId { get; set; }
}