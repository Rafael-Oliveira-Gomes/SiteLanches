using System.ComponentModel.DataAnnotations;

namespace LojaLanche.Core.Dto
{
    public partial class SignUpDto
    {
        [Required(ErrorMessage = "Cpf/Cnpj is required")]
        public string CpfCnpj { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
    }
}
