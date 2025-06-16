using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    // [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        // [Route("")]
        // [Route("~/")]
        // [Route("~/Home")]
        
        
        // private readonly StudentRepository _studentRepository = null;
        //
        // public HomeController(StudentRepository studentRepository)
        // {
        //     _studentRepository = studentRepository;
        // }

        
        
        private readonly IStudentRepository _studentRepositoryRepository = null;

        public HomeController(IStudentRepository studentRepositoryRepository)
        {
            _studentRepositoryRepository = studentRepositoryRepository;
        }
        
        
        
        public List<StudentModel> getAllStudent()
        {
            return _studentRepositoryRepository.getAllStudents();
        }

        public StudentModel getById(int id)
        {
            return _studentRepositoryRepository.getStudentById(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
