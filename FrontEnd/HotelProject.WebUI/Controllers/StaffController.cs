using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
