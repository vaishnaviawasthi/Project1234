//Including all using directives.
using ProjectManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using ProjectManagerUI.ViewModels;
using Exceptions;
using ProjectManagerDAL;

//Introducing namespace for the project.
namespace ProjectManagerUI.Controllers
{

    //The ProjectController is responsible for generating the response to the browser request.
    //ProjectController:Controller will show us that the class inherits Controller.
    //Controller is WebApi controller base class.
    public class ProjectController : Controller
    {

        // IRepository gives us a reliable class hierarchy to work with.
        //EmpRepo is a reference object.
        IRepository<Employee> EmpRepo;


        //objProjectService is a reference object created for the class ProjectService.
        //Value is null in order to specify that objProjectService will be called later.
        ProjectService objProjectService = null;


        //A default constructor is being created for the controller class ProjectController.
        //Reference object objProjectService is called and being initialized with a value.
        //EmpRepo is called and being initialized with a value.
        public ProjectController()
        {
            objProjectService = new ProjectService();           
            EmpRepo = new EmployeeRepository();
        }


        // GET: Project
        public ActionResult Index()
        {
            return View();
        }


        //ActionResult is the return type for this method.
        // GET: Information or data about the projects from the database.
        //Exception-Handling
        public ActionResult ViewProjects()
        {
            try
            {              
                var list = objProjectService.Display();
                var ViewList = new List<ProjectViewModel>();
                foreach (var item in list)
                {
                    ViewList.Add(new ProjectViewModel()
                    {
                        ProjectId = item.ProjectId,
                        ProjectTitle = item.ProjectTitle,
                        ProjectStartDate = item.ProjectStartDate,
                        ProjectEndDate = item.ProjectEndDate,
                        EmployeeId = item.EmployeeId
                    });
                }
                return View("ViewProjects", ViewList);
            }
            catch (ProjectManagerException e)
            {
                return Content("Error" + e.Message);
            }
        }

        // GET: EmployeeId and EmployeeName are being added to the list.
        public ActionResult AddProject()
        {
            var item = new ProjectViewModel();
            item.Employees = new SelectList(EmpRepo.Display(), "EmployeeId", "EmployeeName");
            return View(item);
        }


        //HttpPost is used only to post or create new entry with information or data to database
        //ValidateAntiForgeryToken attribute is to prevent cross-site request forgery attacks.
        //ValidateInput validates if there are any suspicious requests coming on Form submission.
        //ActionResult is the return type for this method.
        // POST: Information about the project to the database.
        //Exception-Handling
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(true)]
        public ActionResult AddProject(ProjectViewModel item)
        {         
            try
            {               
                if (ModelState.IsValid)
                {                  
                    var Project = new Project()
                    {
                        ProjectId = item.ProjectId,
                        ProjectTitle = item.ProjectTitle,
                        ProjectStartDate = item.ProjectStartDate,
                        ProjectEndDate = item.ProjectEndDate,
                        EmployeeId = item.EmployeeId
                    };
                    var Added = objProjectService.AddProject(Project);
                    if (Added)
                    {
                        return RedirectToAction("ViewProjects");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to add");
                        return View(item);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "One or More validation failed");
                    return View(item);
                }
            }
            catch (ProjectManagerException e)
            {
                return Content("Error" + e.Message);
            }
        }
    }
}
