using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
namespace Intsar_F_Project.Controllers
{
    public class AdminController : Controller
    {
        private AppDbContext _App;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;
        public AdminController(AppDbContext App, UserManager<ApplicationUser> applicationUser, SignInManager<ApplicationUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _App = App;
            _userManager = applicationUser;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult AdminHome(string id)
        {

            var contacts = _App.contacts.ToList();
            int Comps = 0;
            int Judges = 0;
            foreach (var item in _roleManager.Roles)
            {
                if (item.Name == "Comp")
                {
                    Comps++;
                }
                if (item.Name == "Judge")
                {
                    Judges++;
                }
            }
            ViewBag.CompsCount = Comps;
            ViewBag.JudgesCount = Judges;
            ViewBag.compReg = _App.compRegs.Where(b => b.IsAccepted == false).ToList();
            ViewBag.contact = _App.contacts.Where(r => r.Id == id).FirstOrDefault();
            ViewBag.requests = _App.contacts.Where(r => r.Id == id).FirstOrDefault();
            return View(contacts);
        }

        public IActionResult CompRequest(int id)
        {
            var RequestComp = _App.compRegs.Where(d => d.Id == id).FirstOrDefault();
            return View(RequestComp);
        }
        [HttpPost]
        public async Task<IActionResult> CompRequest(int id, string fake)
        {
            var requests = _App.compRegs.Where(r => r.Id == id).FirstOrDefault();
            var user = _userManager.Users.Where(u => u.Email == requests.Email).FirstOrDefault();
            requests.IsAccepted = true;
            await _userManager.AddToRoleAsync(user, "Comp");
            _App.SaveChanges();
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Admin");
        }
    }
}
