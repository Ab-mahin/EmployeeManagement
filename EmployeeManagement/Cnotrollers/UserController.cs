using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Cnotrollers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}