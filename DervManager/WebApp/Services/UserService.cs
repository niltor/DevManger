using Core;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class UserService
    {
        readonly DevContext ctx;

        public UserService(DevContext context)
        {
            ctx = context;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await ctx.Users.ToListAsync();
        }

    }
}
