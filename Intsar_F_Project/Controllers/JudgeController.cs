using Intsar_F_Project.Data;
using Intsar_F_Project.Models;
using Intsar_F_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Intsar_F_Project.Controllers
{
    public class JudgeController : Controller
    {
        private AppDbContext _App;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;
        public JudgeController(AppDbContext App, UserManager<ApplicationUser> applicationUser, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _App = App;
            _userManager = applicationUser;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var judge = await _userManager.GetUserAsync(User);  
            var user = _App.compRegs.Where(c=>c.project_type==judge.Specialization).ToList();
            return View(user);
        }

        public IActionResult compInfo(int id)
        {
            var user = _App.degComps.Where(b=>b.compRegId==id).FirstOrDefault();
            if(user==null)
            {
                return RedirectToAction("errorView", "Judge");
            }
            var CompsInfo = _App.degComps.Where(c=>c.compRegId==id).FirstOrDefault();
            return View(CompsInfo);
        }
        public IActionResult compRate(int id)
        {
            var user = _App.compRegs.Where(b => b.Id == id).FirstOrDefault();
            ViewBag.user = _App.projects.Where(b => b.Email == user.Email).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult compRate(int id,DegCompVM degCompVM)
        {
            var user = _App.compRegs.Where(b => b.Id == id).FirstOrDefault();
            var user2 = _App.degComps.Where(b => b.compRegId == id).FirstOrDefault();
            if (user2 != null)
            {
                var degUserr = _App.degComps.Where(c => c.compRegId == id).FirstOrDefault();
                degUserr.ProjectIdea = degCompVM.ProjectIdea;
                degUserr.ExecutionQuality = degCompVM.ExecutionQuality;
                degUserr.Gui = degCompVM.Gui;
                degUserr.ContentQuality = degCompVM.ContentQuality;
                degUserr.complexity = degCompVM.complexity;
                degUserr.ProjectBbenefit = degCompVM.ProjectBbenefit;
                degUserr.language_Tools = degCompVM.language_Tools;
                degUserr.MasteringTheTools = degCompVM.MasteringTheTools;
                degUserr.InfrastructureUsed = degCompVM.InfrastructureUsed;
                degUserr.Notes = degCompVM.Notes;
                degUserr.OverallRating = degCompVM.OverallRating;
                degUserr.Email = user.Email;
                degUserr.compRegId = id;
                _App.SaveChanges();
                return RedirectToAction("Index", "Judge");
            }
            
            var degUser = new DegComp()
            {
                ProjectIdea = degCompVM.ProjectIdea,
                ExecutionQuality = degCompVM.ExecutionQuality,
                Gui = degCompVM.Gui,
                ContentQuality = degCompVM.ContentQuality,
                complexity = degCompVM.complexity,
                ProjectBbenefit = degCompVM.ProjectBbenefit,
                language_Tools = degCompVM.language_Tools,
                MasteringTheTools = degCompVM.MasteringTheTools,
                InfrastructureUsed = degCompVM.InfrastructureUsed,
                Notes = degCompVM.Notes,
                OverallRating = degCompVM.OverallRating,
                Email = user.Email,
                compRegId = id,
            };
            _App.Add(degUser);
            _App.SaveChanges();
            return RedirectToAction("Index", "Judge");
        }

        public IActionResult errorView()
        {
            return View();
        }
    }
}
