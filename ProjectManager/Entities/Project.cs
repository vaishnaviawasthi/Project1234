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

        //Defining class Project with access modifier as public.
        public class Project
        {

        //Declaring attribute key to define ProjectId to be a primary key.
        //Defining ProjectId to be of return type int.
        [Key]
        public int ProjectId { get; set; }

        //Defining string length for the ProjectTitle to be 50.
        //Declaring field ProjectTitle as Required to specify it to be mandatory.
        //Defining datatype for ProjectTitle to be as varchar.
        //Defining ProjectTitle to be of return type string.
        [StringLength(50)]
        [Required]
        [Column(TypeName = "varchar")]
        public string ProjectTitle { get; set; }


        //Declaring field ProjectStartDate as Required to specify it to be mandatory.
        //Defining datatype for ProjectStartDate to be as date.
        //Defining ProjectStartDate to be of return type DateTime.
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ProjectStartDate { get; set; }


        //Declaring field ProjectEndDate as Required to specify it to be mandatory.
        //Defining datatype for ProjectEndDate to be as date.
        //Defining ProjectEndDate to be of return type DateTime.
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ProjectEndDate { get; set; }


        //Declaring attribute ForeignKey to define EmployeeId to be a foreign key.
        //Defining EmployeeId to be of return type int.
        [ForeignKey("Emp")]
        public int EmployeeId { get; set; }

        
        //Marking property as virtual allows entity framework to use lazy loading to load it. 
        //To hold multiple entities type is used in reference to ICollection.
        public virtual ICollection<TaskN> Tasks { get; set; }


        //Marking property as virtual allows entity framework to use lazy loading to load it. 
        public virtual Employee Emp { get; set; }
        }
    }
    