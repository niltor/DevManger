using Core;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services
{
    public class UserService : BaseService
    {

        public UserService(DevContext context) : base(context)
        {
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await ctx.Users.ToListAsync();
        }

        public async Task<User> AddUserAsync(UserForm form)
        {
            var user = new User
            {
                Realname = form.Realname,
                Username = form.Username,
                Password = User.SimpleHash(form.Password),
            };

            ctx.Users.Add(user);
            await ctx.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUserAsync(Guid id)
        {
            var user = ctx.Users.Find(id);
            ctx.Users.Remove(user);
            await ctx.SaveChangesAsync();
            return user;

        }
    }
}
