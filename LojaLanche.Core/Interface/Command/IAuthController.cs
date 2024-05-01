using LojaLanche.Core.Dto;
using LojaLanche.Data.Model;
using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Core.Interface.Command
{
    public interface IAuthController
    {
        Task<ResponseCommon<bool>> AddUserToAdminRole(int userId);
        Task<ResponseCommon<UserBase>> GetCurrentUser();
        Task<ResponseCommon<UserDto>> GetUserDto(int id);
        Task<ResponseCommon<List<ApplicationUser>>> ListUsers();
        Task<ResponseCommon<SsoDto>> SignIn(SignInDto signInDTO);
        Task<ResponseCommon<bool>> SignUp(SignUpDto signUpDto);
    }
}