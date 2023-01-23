
using System.ComponentModel.DataAnnotations;

namespace NullabilityDemo;

public class UserClass
{
    [Required]
    public string FirstName { get; init; }
    public required string LastName { get; set; }

    public UserClass()
    {
        FirstName = string.Empty;
    }

}
