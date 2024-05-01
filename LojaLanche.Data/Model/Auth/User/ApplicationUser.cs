namespace LojaLanche.Data.Model.Auth.User
{
    public class ApplicationUser : UserBase
    {
        public DateTime DataNascimento { get; set; }
        public required string CpfCnpj { get; set; }
    }
}
