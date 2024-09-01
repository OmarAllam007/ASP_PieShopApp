using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace PieShopApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public List<OrderDetail>? OrderDetails { get; set; }
    public decimal TotalPrice { get; set; }
    
    [Required(ErrorMessage = "Please enter your first name")]
    [Display(Name = "First name")]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your last name")]
    [Display(Name = "Last name")]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your address")]
    [Display(Name = "Address line 1")]
    [StringLength(100)]
    public string AddressLine1 { get; set; } = string.Empty;
    
    [Display(Name = "Address line 2")]
    public string? AddressLine2 { get; set; }
    
    [Required(ErrorMessage = "Please enter your zip code")]
    [Display(Name = "Zip code")]
    [StringLength(10, MinimumLength = 4)]
    public string ZipCode { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your city")]
    [StringLength(50)]
    public string City { get; set; } = string.Empty;
    public string? State { get; set; }
    
    [Required(ErrorMessage = "Please enter your country")]
    [StringLength(50)]
    public string Country { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter your phone number")]
    [StringLength(25)]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Phone number")]
    public string PhoneNumber { get; set; } = string.Empty;
    
    [Required]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = string.Empty;
    
    [BindNever]
    public decimal OrderTotal { get; set; }
    [BindNever]
    public DateTime OrderPlaced { get; set; }
    
    
}