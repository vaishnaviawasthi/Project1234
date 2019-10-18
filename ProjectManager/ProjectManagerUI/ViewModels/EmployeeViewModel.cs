//Including all using directives.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ProjectManagerDAL;

//Introducing namespace for the project.
namespace ProjectManagerUI.ViewModels
{

    //Defining class EmployeeViewModel with access modifier as public.
    public class EmployeeViewModel
    {

        //Defining method EmployeeId to be of return type int.
        public int EmployeeId { get; set; }


        //Defining string length for the EmployeeName to be 50. 
        [StringLength(50)]
        //Declaring field EmployeeName as Required to specify it to be mandatory.
        [Required]
        //Displaying EmployeeName under name of "Enter Employee Name".
        [Display(Name = "Enter Employee Name")]
        //Defining method EmployeeName to be of return type string.
        public string EmployeeName { get; set; }


        //Defining string length for the EmployeeDesignation to be 50. 
        [StringLength(30)]
        //Declaring field EmployeeDesignation as Required to specify it to be mandatory.
        [Required]
        //Displaying EmployeeDesignation under name of "Enter Employee Name".
        [Display(Name = "Enter Employee Designation")]
        //Defining method EmployeeDesignation to be of return type string.
        public string EmployeeDesignation { get; set; }
    }
}