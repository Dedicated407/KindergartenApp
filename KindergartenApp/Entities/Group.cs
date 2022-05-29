using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Models;

public class Group : BaseEntity
{
    [Display(Name = "Название группы")]
    public string Name { get; set; }
    
    [BsonId]
    [Display(Name = "Воспитатель")]
    public string KindergartenTeacherId { get; set; }
    
    [BsonId]
    [Display(Name = "Нянечка")]
    public string BabysitterId { get; set; }
}