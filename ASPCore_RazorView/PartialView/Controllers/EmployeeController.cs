using Microsoft.AspNetCore.Mvc;
using RazorViewModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _EmployeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult GetEmployeeList()
        {
            var elist = _EmployeeRepository.getEmployees();
            return View(elist);
        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = _EmployeeRepository.GetById(id);
            return View(emp);
        }
    }
}
