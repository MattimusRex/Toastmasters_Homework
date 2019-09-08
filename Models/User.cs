using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesToastmaster.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(12, MinimumLength = 5)]
        [RegularExpression(@"^(?=([a-zA-Z]+[0-9])|([0-9]+[a-zA-Z]))(?!.*(.{2,})\3.*)[a-zA-Z0-9]*$", 
            ErrorMessage = "Password be alphanumeric with at least 1 number and 1 letter. " +
                            "Password may not contain a sequence of characters immediately followed by the same sequence.")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
