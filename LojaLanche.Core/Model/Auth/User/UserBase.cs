using Microsoft.AspNetCore.Identity;

namespace LojaLanche.Core.Model.Auth.User
{
    public class UserBase : IdentityUser<int>
    {
        public string Nome { get; set; } = null!;
        public string Discriminator { get; set; } = null!;
    }
}
