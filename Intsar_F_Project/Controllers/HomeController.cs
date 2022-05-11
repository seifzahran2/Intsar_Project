using Intsar_F_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Intsar_F_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
namespace Intsar_F_Project.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _App;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        public HomeController(AppDbContext App, UserManager<ApplicationUser> applicationUser, SignInManager<ApplicationUser> signInManager)
        {
            _App = App;
            _userManager = applicationUser;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult magalatA()
        {
            return View();
        }
        public IActionResult magalatF()
        {
            return View();
        }
        public IActionResult magalatB()
        {
            return View();
        }
        public IActionResult winnersA()
        {
            return View();
        }
        public IActionResult winnersF()
        {
            return View();
        }
        public IActionResult winnersB()
        {
            return View();
        }
       
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactVM model)
        {
            var message = new Contact()
            {
                FullName = model.FullName,
                Email =model.Email,
                Subject = model.Subject,
                Message = model.Message,
            };
            _App.Add(message);
            _App.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
