using System;
using System.ComponentModel.DataAnnotations;

namespace ThomasClaudiusHuber.FormsAndValidation.Model
{
  public class Employee
  {
    [Required]
    [StringLength(20, ErrorMessage = "Firstname is too long (20 characters limit)")]
    public string FirstName { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string JobRole { get; set; }

    [Required]
    public DateTimeOffset JobEntryDate { get; set; }

    [Range(0, 10, ErrorMessage = "Skill level must be an integer between 0 and 10")]
    public int BlazorSkillLevel { get; set; }
  }
}
