using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Core.Dto
{
    public class UserDto
    {
        public UserDto() { }
        public UserDto(ApplicationUser user) 
        {
            UserName = user.UserName!;
            Email = user.Email!;
        }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
