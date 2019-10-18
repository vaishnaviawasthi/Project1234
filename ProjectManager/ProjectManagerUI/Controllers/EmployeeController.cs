//Including all using directives.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Introducing namespace for an employee.
namespace ProjectManagerUI.Controllers
{

    //The EmployeeController is responsible for generating the response to the browser request.
    //EmployeeController:Controller will show us that the class inherits Controller.
    //Controller is WebApi controller base class.
    public class EmployeeController : Controller
    {
        // Display employees.
        public ActionResult Index()
        {
            return View();
        }

        ////ActionResult is the return type for this method.
        // GET: Employee
        public ActionResult Add()
        {
            return View();
        }
    }
}