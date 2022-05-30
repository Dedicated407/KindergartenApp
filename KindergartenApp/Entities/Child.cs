using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace KindergartenApp.Entities;

public class Child : BaseEntity
{
    [Display(Name = "ФИО")]
    public string FullName { get; set; }
    
    [Display(Name = "Номер группы")]
    public Guid GroupId { get; set; }
    
    [Display(Name = "Дата рождения")]
    public DateTime Birthday { get; set; }
    
    [Display(Name = "Номер свидетельства о рождении")]
    public string CertificateNumber { get; set; }
}