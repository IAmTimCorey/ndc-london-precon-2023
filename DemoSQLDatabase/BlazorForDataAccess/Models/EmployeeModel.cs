using System.ComponentModel.DataAnnotations;

namespace BlazorForDataAccess.Models;

public class EmployeeModel
{
    public int Id { get; set; }

    [Required]
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
