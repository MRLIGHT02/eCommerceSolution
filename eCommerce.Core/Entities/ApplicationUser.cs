using System.ComponentModel.DataAnnotations;

namespace eCommerce.Core.Entities;

/// <summary>
/// Define the ApplicationUser entity class. which acts as entity model class to store user details in data.
/// </summary>
public class ApplicationUser
{
    [Key]
    public Guid UserId { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PersonName { get; set; }
    public string? Gender { get; set; }

}

