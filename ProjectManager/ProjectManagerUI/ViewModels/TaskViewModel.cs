//Including all using directives.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//Introducing namespace for the project.
namespace ProjectManagerUI.ViewModels
{

    //Defining class TaskViewModel with access modifier as public.
    public class TaskViewModel
    {
        //Declaring attribute key to define TaskId to be a primary key.
        [Key]
        //Defining method TaskId to be of return type int.
        public int TaskId { get; set; }


        //Defining string length for the TaskName to be 100. 
        [StringLength(100)]
        //Declaring field TaskName as Required to specify it to be mandatory.
        [Required]
        //Defining method TaskName to be of return type string.
        public string TaskName { get; set; }


        //Defining string length for the TaskDescription to be 100.
        [StringLength(300)]
        //Defining method TaskDescription to be of return type string.
        public string TaskDescription { get; set; }


        //Declaring field TaskStartDate as Required to specify it to be mandatory.
        [Required]
        //Defining method TaskStartDate to be of return type DateTime.
        public DateTime TaskStartDate { get; set; }


        //Declaring field TaskEndDate as Required to specify it to be mandatory.
        [Required]
        //Defining method TaskEndDate to be of return type DateTime.
        public DateTime TaskEndDate { get; set; }


        //[RegularExpression("^[1 - 5]{1}$")]
        //Defining method TaskPriority to be of return type int.
        public int TaskPriority { get; set; }


        //Declaring field TaskStatus as Required to specify it to be mandatory.
        [Required]
        //Defining method TaskStatus to be of return type string.
        public string TaskStatus { get; set; }


        //Defining method ProjectId to be of return type int.
        public int ProjectId { get; set; }


        //Defining method EmployeeId to be of return type int.
        public int EmployeeId { get; set; }
       
        
    }
}