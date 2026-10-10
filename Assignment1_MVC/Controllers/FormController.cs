using Assignment1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_MVC.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EquipmentRequest()
        {
            return View("~/Views/Equipment/EquipmentRequest.cshtml");
        }

        [HttpPost]
        public IActionResult RequestForm(Form model)
        {
         
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View("Approved", model);
        }
    }
}
