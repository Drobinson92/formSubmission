using System.ComponentModel.DataAnnotations;
namespace formsubmission.Models{
    public class User : BaseEntity{
        [Required]
        [MinLength(4)]
        public string FirstName {get; set;} //min 4 char
        [Required]
        [MinLength(4)]
        public string LastName {get; set;} //min 4 char
        [Required]
        [Range(18, 85)]
        public int Age {get; set;} //must be positive
        [Required]
        [EmailAddress]
        public string Email {get; set;} //must be valid email format
        [Required]
        [MinLength(8)]
        public string Password {get; set;} //min 8 char

    }
}