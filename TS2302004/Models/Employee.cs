using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TS2302004.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [MaxLength(60)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Date of Birth is required")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
    public DateTime? DoB { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Address must be between 6 and 100 characters")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format")]
    [MaxLength(40)]
    public string? Email { get; set; }
}
