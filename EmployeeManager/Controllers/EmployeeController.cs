using EmployeeManager.Shared.ViewModels;
using EmployeeManager.Shared.Orchestrators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using EmployeeManager.Models;
using EmployeeManager.Domain.Entities;

namespace EmployeeManager.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private EmployeeOrchestrator _employeeOrchestrator = new EmployeeOrchestrator();
        public async Task<ActionResult> Index()
        {
            var employeeDisplayModel = new Models.EmployeeDisplayModel
            {
                Employees = await _employeeOrchestrator.GetAllEmployees()
            };
            return View(employeeDisplayModel);
        }
        public async Task<ActionResult> Create(CreateEmployeeModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FirstName))
            return View();
            var updatedCount = await _employeeOrchestrator.CreateEmployee(new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName ,
                BirthDate = employee .BirthDate ,
                HireDate = employee .HireDate ,
                Department = employee .Department ,
                JobTitle = employee .JobTitle ,
                Salary = employee .Salary ,
                EmployeeId = employee .EmployeeId ,
                AvailableHours = employee .AvailableHours 

            });
            return View();
        }
    }
           
        }

