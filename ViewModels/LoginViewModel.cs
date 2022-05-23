using System.ComponentModel.DataAnnotations;

namespace F1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Login required")]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
