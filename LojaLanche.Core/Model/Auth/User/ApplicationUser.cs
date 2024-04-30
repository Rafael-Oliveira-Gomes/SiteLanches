using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLanche.Core.Model.Auth.User
{
    public class ApplicationUser : UserBase
    {
        public DateTime DataNascimento { get; set; }
        public required string CpfCnpj { get; set; }
    }
}
