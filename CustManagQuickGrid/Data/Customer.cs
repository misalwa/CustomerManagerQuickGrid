using System.ComponentModel.DataAnnotations;

namespace CustManagQuickGrid.Data;

public class Customer
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The First Name field is required")]
    [MaxLength(15, ErrorMessage = "First name length must be less than 15 letters")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "The Last Name field is required")]
    [MaxLength(20, ErrorMessage = "Last name length must be less than 20 letters")]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50, ErrorMessage = "Email length must be less than 50 letters")]
    [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(20, ErrorMessage = "Phone number length must be less than 20 letters")]
    public string Phone { get; set; } = string.Empty;
}
