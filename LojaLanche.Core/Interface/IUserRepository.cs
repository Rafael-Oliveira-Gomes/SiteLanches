using LojaLanche.Core.Model.Auth.User;
using LojaLanche.Interface.Repository.Generic;

namespace LojaLanche.Core.Interface
{
    public interface IUserRepository : IGenericRepository<ApplicationUser, int>
    {
        Task<List<ApplicationUser>> ListUsers();
    }
}
