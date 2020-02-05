using Core;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public class AccountService : BaseService
    {
        public AccountService(DevContext context) : base(context)
        {
        }


   
    }
}
