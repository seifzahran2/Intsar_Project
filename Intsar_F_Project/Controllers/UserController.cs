using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Intsar_F_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Intsar_F_Project.Controllers
{
    public class UserController : Controller
    {
        private AppDbContext _App;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        public UserController(AppDbContext App, UserManager<ApplicationUser> applicationUser, SignInManager<ApplicationUser> signInManager)
        {
            _App = App;
            _userManager = applicationUser;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> CompRegs()
        {
            ViewBag.user = await _userManager.GetUserAsync(User);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CompRegs(CompRegVM compRegVM)
        {
            var user = await _userManager.GetUserAsync(User);
            var compReg = new CompReg()
            {
                FullName = compRegVM.FullName,
                Email = compRegVM.Email,
                Address = compRegVM.Address,
                BankAccount = compRegVM.BankAccount,
                NationalId = compRegVM.NationalId,
                Age = compRegVM.Age,
                CompNum = compRegVM.CompNum,
                Gender = compRegVM.Gender,
                project_type = compRegVM.project_type,
                Educational_level = compRegVM.Educational_level,
                AgeType = compRegVM.AgeType,
                educational_system = compRegVM.educational_system,
                
            };
            
            if (user.Email != compRegVM.Email || user.NationalID != compRegVM.NationalId)
            {
                TempData["Message"] = "يجب ان يكون الرقم القومي و البريد الالكتروني مطابق لتسجيل الدخول ، راجع صفحتك الشخصية.";
                return RedirectToAction("CompRegs", "User");
            }
            _App.compRegs.Add(compReg);
            _App.SaveChanges();
            user.IsRegSent = true;
            user.Specialization = compRegVM.project_type;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("CompRegs","User");
        }

        public async Task<IActionResult> Profile()
        {
            var user =await _userManager.GetUserAsync(User);
            ViewBag.Comp = _App.compRegs.Where(b => b.Email == user.Email).FirstOrDefault();
            return View(user);
        }


    }
}
