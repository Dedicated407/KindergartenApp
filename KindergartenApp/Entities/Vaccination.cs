using System.ComponentModel.DataAnnotations;

namespace KindergartenApp.Entities;

public class Vaccination : BaseEntity
{
    [Display(Name = "Название прививки")]
    public string Name { get; set; }
    
    [Display(Name = "Описание")]
    public string Description { get; set; }
}