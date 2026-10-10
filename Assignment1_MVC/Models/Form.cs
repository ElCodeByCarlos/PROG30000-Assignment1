using System.ComponentModel.DataAnnotations;

namespace Assignment1_MVC.Models
{
    public class Form
    {
        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress (ErrorMessage = "Invalid email address")]
        public String Email { get; set; } = "";

        [Required(ErrorMessage = "Phone is required")]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public String Phone { get; set; } = "";

        [Required(ErrorMessage = "Role is required")]
        public String Role { get; set; } = "";

       
        public enum EquipmentType
        {
            Laptop,
            Phone,
            Tablet,
            Wii,
            Xbox,
            Microwave,
            Eggs
        }

        [Required]
        public EquipmentType? Equipment { get; set; }

        [Required]
        public String Details { get; set; } = "";

        [Required]
        [Range(1, 100, ErrorMessage = "Quantity of days must be greater than 0.")]
        public int? Duration { get; set; } = 0;

    }
}
