using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Assignment1_MVC.Models
{
    public static class EnumDescription
    {
        public static string GetDisplayName(this Enum equipDescription)
        {
            return equipDescription.GetType()
                .GetMember(equipDescription.ToString())
                        .FirstOrDefault()?
                        .GetCustomAttribute<DisplayAttribute>()?
                        .GetName() ?? equipDescription.ToString();
        }
    }
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
            [Display(Name = "This is a school laptop")]
            Laptop,
            [Display(Name = "This is a school phone")]
            Phone,
            [Display(Name = "This is a school tablet")]
            Tablet,
            [Display(Name = "This is a school Wii Console")]
            Wii,
            [Display(Name = "This is a school Xbox Console")]
            Xbox,
            [Display(Name = "This is a school Microwave")]
            Microwave,
            [Display(Name = "These are school Eggs")]
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
