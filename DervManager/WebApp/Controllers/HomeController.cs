using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Entity;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly ApplicationDbContext _context;
        readonly UserManager<AppUser> _userManager;
        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context,
            UserManager<AppUser> userManager
            )
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> InitAsync()
        {
            var admin = new AppUser
            {
                UserName = "admin",
                Email = "admin@admin.com"

            };
            var role = new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "Admin"
            };
            Console.WriteLine("===" + _userManager.ToString());
            _context.Roles.Add(role);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
