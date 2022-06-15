using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Intsar_F_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            if (User.IsInRole("User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            else if (User.IsInRole("Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            
            else if (User.IsInRole("Judge"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "Comp");
            _App.SaveChanges();
            await _userManager.UpdateAsync(user);
            return RedirectToAction("AdminHome", "Admin");
        }
        public IActionResult Message(string id)
        {
           
            var Message = _App.contacts.Where(d => d.Id == id).FirstOrDefault();
            return View(Message);
        }
        public  IActionResult UserMangment()
        {
            var users =  _userManager.Users.Select(user => new UserVM
            {
                Id = user.Id,
                Name = user.Name,
                Specialization = user.Specialization,
                Email = user.Email,
                user=user
            }).ToList();
            foreach (var user in users)
            {
                user.Roles = _userManager.GetRolesAsync(user.user).Result;
            }
            return View(users);
        }
        public IActionResult JopSelction(string id)
        {

            var JopSelction = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();

            return View(JopSelction);
        }
        [HttpPost]
        public async Task<IActionResult> JopSelction(string id, ApplicationUser _user)
        {
            var user = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();

            user.Specialization = _user.Specialization;
            
            var role = _userManager.GetRolesAsync(user).Result[0];
            if (_user.Role == "متحكم")
            {
                await _userManager.RemoveFromRoleAsync(user, role);
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            else if (_user.Role == "مستخدم")
            {
                await _userManager.RemoveFromRoleAsync(user, role);
                await _userManager.AddToRoleAsync(user, "User");
            }
            else if (_user.Role == "مصحح")
            {
                await _userManager.RemoveFromRoleAsync(user, role);
                await _userManager.AddToRoleAsync(user, "Judge");
            }

            await _userManager.UpdateAsync(user);

            return RedirectToAction("UserMangment");
        }

        public IActionResult ResultHome()
        {
            var user = _App.compRegs.Where(u=> u.IsAccepted==true).ToList();
            return View(user);
        }


        public IActionResult compInfo(int id)
        {
            var user = _App.degComps.Where(b => b.compRegId == id).FirstOrDefault();
            if (user == null)
            {
                return RedirectToAction("errorView", "Admin");
            }
            var CompsInfo = _App.degComps.Where(c => c.compRegId == id).FirstOrDefault();
            return View(CompsInfo);
        }

        public IActionResult errorView()
        {
            return View();
        }

        public IActionResult UserInfo(string id)
        {
            var userVM = _userManager.Users.Select(user => new UserVM
            {
                Name = user.Name,
                Email = user.Email,
                NationalID = user.NationalID,
                mobileNumber = user.mobileNumber,
                age = user.age,
                Specialization = user.Specialization,
                user = user,
                gender = user.gender,
            }).FirstOrDefault();
            userVM.Roles = _userManager.GetRolesAsync(userVM.user).Result;
            return View(userVM);
        }
    }
}
