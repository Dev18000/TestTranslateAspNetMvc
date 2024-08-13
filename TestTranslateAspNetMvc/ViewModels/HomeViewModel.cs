using System.ComponentModel.DataAnnotations;

namespace TestTranslateAspNetMvc.ViewModels
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address")]
        [Display(Name = "Your Email")]
        public string Email { get; set; }
    }
}
