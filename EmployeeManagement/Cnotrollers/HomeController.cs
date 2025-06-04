using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Cnotrollers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("[action]")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

