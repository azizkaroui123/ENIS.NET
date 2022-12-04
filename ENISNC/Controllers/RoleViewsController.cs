///using ASP.NETCoreIdentityCustom.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreIdentityCustom.Controllers
{
    public class RoleViewsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Teacher()
        {
            return View();
        }

        [Authorize(Roles = "Student")]
        public IActionResult Student()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }
    }
}
