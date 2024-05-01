using LojaLanche.Core.Dto;
using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Core.Interface.Service
{
    public interface IAuthService
    {
        Task<List<ApplicationUser>> ListUsers();
        Task<ApplicationUser> GetUserById(int userId);
        Task<UserDto> GetUserDto(int userId);
        Task<int> UpdateUser(ApplicationUser user);
        Task<bool> DeleteUser(int userId);
        Task<bool> SignUp(SignUpDto signUpDto);
        Task<SsoDto> SignIn(SignInDto signInDto);
        Task AddUserToAdminRole(int userId);
        Task<UserBase> GetCurrentUser();
    }
}
