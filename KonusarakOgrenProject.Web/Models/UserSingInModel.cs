using System.ComponentModel.DataAnnotations;

namespace KonusarakOgrenProject.Web.Models
{
    public class UserSingInModel
    {
        [Required(ErrorMessage ="Lütfen Mail Adresinizi Giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Adresinizi Giriniz.")]
        public string Password { get; set; }

    }
}
