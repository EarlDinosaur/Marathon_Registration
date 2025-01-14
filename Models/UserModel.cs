using System.ComponentModel.DataAnnotations;

namespace Marathon_Registration.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Enter a valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Race category is required.")]
        public string RaceCategory { get; set; }

        [Required(ErrorMessage = "T-shirt size is required.")]
        public string TShirtSize { get; set; }

        [Required(ErrorMessage = "You must agree to the terms.")]
        public bool AgreeToTerms { get; set; }
    }
}
