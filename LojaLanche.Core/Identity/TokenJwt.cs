﻿using System.IdentityModel.Tokens.Jwt;

namespace LojaLanche.Core.Identity
{
    public class TokenJwt
    {
        private readonly JwtSecurityToken token;

        internal TokenJwt(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime ValidTo => token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(token);
    }
}
