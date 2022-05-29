using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Models;

public class Child : BaseEntity
{
    [Display(Name = "ФИО")]
    public string FullName { get; set; }
    
    [BsonId]
    public string GroupId { get; set; }
    
    [Display(Name = "Дата рождения")]
    public DateTime Birthday { get; set; }
    
    [Display(Name = "Номер свидетельства о рождении")]
    public string CertificateNumber { get; set; }
}