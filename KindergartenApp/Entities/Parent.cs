﻿using System.ComponentModel.DataAnnotations;

namespace KindergartenApp.Models;

public class Parent : BaseEntity
{
    [Display(Name = "ФИО")]
    public string FullName { get; set; }
    
    [Display(Name = "Номер телефона")]
    public string PhoneNumber { get; set; }
    
    [Display(Name = "Адрес проживания")]
    public string Address { get; set; }
    
    [Display(Name = "Должность")]
    public string? Position { get; set; }
}