using Microsoft.AspNetCore.Mvc;

namespace Assignment1_MVC.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult AllEquipmentListing()
        {
            return View();
        }
    }
}
