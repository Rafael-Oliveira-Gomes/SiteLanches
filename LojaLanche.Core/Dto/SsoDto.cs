using LojaLanche.Data.Model.Auth.User;

namespace LojaLanche.Core.Dto
{
    public class SsoDto(string access_token, UserBase user)
    {
        public string Access_token { get; set; } = access_token;
        public DayOfWeek Expiration { get; set; } = DateTime.UtcNow.DayOfWeek;
        public UserBase User { get; set; } = user;
    }
}
