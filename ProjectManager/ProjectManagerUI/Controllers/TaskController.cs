//Including all using directives.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using ProjectManagerUI.ViewModels;
using Exceptions;
using ProjectManagerDAL;
using ProjectmanagerBLL;

//Introducing namespace for the task.
namespace ProjectManagerUI.Controllers
{
    //The TaskController is responsible for generating the response to the browser request.
    //TaskController:Controller will show us that the class inherits Controller.
    //Controller is WebApi controller base class.
    public class TaskController : Controller
    {

        // GET: Task
        public ActionResult Index()
        {
            return View("Home");
        }


        //ActionResult is the return type for this method.
        // GET: Information or data about the tasks from the database.
        //Exception-Handling     
        public ActionResult ViewTasks()
        {
            try
            {
                var objTaskService = new TaskService();
                var list = objTaskService.Display();
                var ViewList = new List<TaskViewModel>();
                foreach (var item in list)
                {
                    ViewList.Add(new TaskViewModel() { TaskId = item.TaskId, TaskName = item.TaskName, TaskDescription = item.TaskDescription, TaskStartDate = item.TaskStartDate, TaskEndDate = item.TaskEndDate, TaskStatus=item.TaskStatus, ProjectId = item.ProjectId, EmployeeId = item.EmployeeId });
                }
                return View("ViewTasks", ViewList);
            }
            catch (ProjectManagerException e)
            {
                return Content("Error"+e.Message);
            }
        }


        //public ActionResult ViewTaskByStatus()
        //{
        //    try
        //    {
        //        var list = ViewTaskByStatus.Pending();
        //        var ViewList = new List<TaskViewModel>();
        //        foreach (var item in list)
        //        {
        //            ViewList.Add(new TaskViewModel() { TaskId = item.TaskId, TaskName = item.TaskName, TaskDescription = item.TaskDescription, TaskStartDate = item.TaskStartDate, TaskEndDate = item.TaskEndDate, TaskStatus = item.TaskStatus });
        //        }
        //        return View("ViewTask", ViewList);
        //    }
        //    catch (ProjectManagerException e)
        //    {
        //        return Content("Error" + e.Message);
        //    }
        //}


        // GET: Task details.
        public ActionResult AddTask()
        {
            return View("AddTask");
        }


        //HttpPost is used only to post or create new entry with information or data to database.
        //ActionResult is the return type for this method.
        // POST: Information about the task to the database.
        //Exception-Handling
        [HttpPost]
        public ActionResult AddTask(TaskViewModel item)
        {
            TaskN task = new TaskN() { TaskId = item.TaskId, TaskName = item.TaskName, TaskDescription = item.TaskDescription, TaskStartDate = item.TaskStartDate,TaskPriority = item.TaskPriority,TaskStatus =item.TaskStatus, TaskEndDate = item.TaskEndDate, ProjectId = item.ProjectId, EmployeeId = item.EmployeeId };
            try
            {
                var objTaskService = new TaskService();
                if (objTaskService.AddTask(task))
                {
                    return RedirectToAction("ViewProjects");
                }
                return Content("Cannot Add Task");
            }
            catch (ProjectManagerException e)
            {
                throw;
            }
        }
    }
}
