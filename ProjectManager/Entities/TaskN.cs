//Including all using directives.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Introducing namespace for the project.
namespace ProjectManagerDAL
{
    //Defining class TaskN with access modifier as public.
    public class TaskN
    {

        //Declaring attribute key to define TaskId to be a primary key.
        [Key]
        //Defining TaskId to be of return type int.
        public int TaskId { get; set; }


        //Defining string length for the TaskName to be 100. 
        [StringLength(100)]
        //Declaring field TaskName as Required to specify it to be mandatory.
        [Required]
        //Defining datatype for TaskName to be as varchar.
        [Column(TypeName = "varchar")]
        //Defining TaskName to be of return type string.       
        public string TaskName { get; set; }


        //Defining string length for the TaskDescription to be 300. 
        [StringLength(300)]
        //Defining datatype for TaskDescription to be as varchar.
        [Column(TypeName = "varchar")]
        //Defining TaskDescription to be of return type string. 
        public string TaskDescription { get; set; }


        //Declaring field TaskStartDate as Required to specify it to be mandatory.
        [Required]
        //Defining datatype for TaskStartDate to be as Date.
        [Column(TypeName = "Date")]
        //Defining TaskStartDate to be of return type DateTime. 
        public DateTime TaskStartDate { get; set; }


        //Declaring field TaskEndDate as Required to specify it to be mandatory.
        [Required]
        //Defining datatype for TaskEndDate to be as Date.
        [Column(TypeName = "Date")]
        //Defining TaskEndDate to be of return type DateTime. 
        public DateTime TaskEndDate { get; set; }


        //[RegularExpression("^[1 - 5]{1}$")]
        //Defining datatype for TaskPriority to be as int.       
        [Column(TypeName = "int")]
        //Defining TaskPriority to be of return type int.
        public int TaskPriority { get; set; }


        //Defining datatype for TaskStatus to be as varchar.    
        [Column(TypeName = "varchar")]
        //Defining TaskStatus to be of return type string.
        public string TaskStatus { get; set; }


        //Declaring attribute ForeignKey to define ProjectId to be a foreign key.
        [ForeignKey("P")]
        //Defining ProjectId to be of return type int.
        public int ProjectId { get; set; }


        //Declaring attribute ForeignKey to define EmployeeId to be a foreign key.
        [ForeignKey("Emp")]
        //Defining EmployeeId to be of return type int.
        public int EmployeeId { get; set; }


        //Marking property as virtual allows entity framework to use lazy loading to load it. 
        public virtual Project P { get; set; }


        //Marking property as virtual allows entity framework to use lazy loading to load it. 
        public virtual Employee Emp { get; set; }
        
    }
}
