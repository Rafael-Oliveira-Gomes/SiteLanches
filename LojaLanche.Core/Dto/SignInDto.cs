using System.ComponentModel.DataAnnotations;

namespace LojaLanche.Core.Dto
{
    public class SignInDto(string username, string password)
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; } = username;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = password;
    }
}
