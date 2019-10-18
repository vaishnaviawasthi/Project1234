//Including all using directives.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

//Introducing namespace for the project.
namespace ProjectManagerUI.ViewModels
{

    //Defining class ProjectViewModel with access modifier as public.
    public class ProjectViewModel
    {

        //Defining method ProjectId to be of return type int.
        public int ProjectId { get; set; }


        //Defining string length for the ProjectTitle to be 50. 
        [StringLength(50)]
        //Declaring field ProjectTitle as Required to specify it to be mandatory.
        [Required]
        //Defining method ProjectTitle to be of return type string.
        public string ProjectTitle { get; set; }


        //Declaring field ProjectStartDate as Required to specify it to be mandatory.
        [Required]
        //Defining method ProjectStartDate to be of return type DateTime.
        public DateTime ProjectStartDate { get; set; }

        //Declaring field ProjectEndDate as Required to specify it to be mandatory.
        [Required]
        //Defining method ProjectEndDate to be of return type DateTime.
        public DateTime ProjectEndDate { get; set; }


        //Defining method EmployeeId to be of return type int.
        public int EmployeeId { get; set; }
        public SelectList Employees { get; internal set; }
    }
}