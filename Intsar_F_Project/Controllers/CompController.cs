using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Intsar_F_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Intsar_F_Project.Controllers
{
    public class CompController : Controller
    {
        private AppDbContext _App;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        public CompController(AppDbContext App, UserManager<ApplicationUser> applicationUser, SignInManager<ApplicationUser> signInManager)
        {
            _App = App;
            _userManager = applicationUser;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> uploadProject()
        {
            ViewBag.user = await _userManager.GetUserAsync(User);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> uploadProject(_ProjectVM projectVM)
        {
            var user = await _userManager.GetUserAsync(User);
            
            var compSp = _App.compRegs.Where(b => b.Email == user.Email).FirstOrDefault(); 
            var project = new _Project()
            {
                FullName = projectVM.FullName,
                DriveLink = projectVM.DriveLink,
                Specialization = compSp.project_type,
                Email = compSp.Email
               
            };
            compSp.IsprojecSent=true;
            _App.Add(project);
            _App.SaveChanges();
            user.IsProjSent = true;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("uploadProject","Comp");
        }
    }
}
