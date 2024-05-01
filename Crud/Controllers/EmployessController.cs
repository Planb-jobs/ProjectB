using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    public class EmployessController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
