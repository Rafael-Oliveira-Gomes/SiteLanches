using LojaLanche.Data.Model.Auth.User;
using LojaLanche.Interface.Repository.Generic;

namespace LojaLanche.Core.Interface.Repository
{
    public interface IUserRepository : IGenericRepository<ApplicationUser, int>
    {
        Task<List<ApplicationUser>> ListUsers();
    }
}
