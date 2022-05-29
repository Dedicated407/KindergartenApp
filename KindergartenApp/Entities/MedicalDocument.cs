using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Entities;

public class MedicalDocument
{
    [BsonId]
    public Guid Id { get; private set; }
    
    public Guid ChildId { get; set; }
    
    public Guid VaccinationId { get; set; }

    public MedicalDocument()
    {
        Id = Guid.NewGuid();
    }
}