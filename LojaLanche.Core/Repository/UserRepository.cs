﻿using LojaLanche.Core.Context;
using LojaLanche.Core.Interface;
using LojaLanche.Core.Model.Auth.User;
using LojaLanche.Core.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaLanche.Core.Repository
{
    public class UserRepository : GenericRepository<ApplicationUser, int>, IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> ListUsers()
        {
            List<ApplicationUser> list = await _context.User.ToListAsync();

            return list;
        }
    }
}
