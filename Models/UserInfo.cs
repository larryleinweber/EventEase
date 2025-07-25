using System.ComponentModel.DataAnnotations;

public class UserInfo
{
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }
    public DateTime LastLogin { get; set; } = DateTime.MinValue;
}
