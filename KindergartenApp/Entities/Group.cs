using System.ComponentModel.DataAnnotations;

namespace KindergartenApp.Entities;

public class Group : BaseEntity
{
    [Display(Name = "Название группы")]
    public string Name { get; set; }
    
    [Display(Name = "Воспитатель")]
    public Guid KindergartenTeacherId { get; set; }

    [Display(Name = "Нянечка")]
    public Guid BabysitterId { get; set; }
}