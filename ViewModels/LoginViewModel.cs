using System.ComponentModel.DataAnnotations;

namespace WebCodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatorio!")]
        public string? email { get; set; }

        [Required(ErrorMessage ="Senha obrigatoria!")]
        public string? senha { get; set; }
    }
}
