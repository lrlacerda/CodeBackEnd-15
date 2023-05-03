using System.ComponentModel.DataAnnotations;

namespace ChapterFS15.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe email do usuário")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string senha { get; set; }
    }
}
