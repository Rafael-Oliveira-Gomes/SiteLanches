using System.ComponentModel.DataAnnotations;

namespace LojaLanche.Core.Dto
{
    public partial class SignUpDto
    {
        [Required(ErrorMessage = "Cpf/Cnpj is required")]
        public required string CpfCnpj { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public required string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        public required string PhoneNumber { get; set; }
    }
}
