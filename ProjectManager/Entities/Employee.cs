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
    //Defining class Employee with access modifier as public.
    public class Employee
    {

        //Declaring attribute key to define EmployeeId to be a primary key.
        [Key]
        //Defining EmployeeId to be of return type int.
        public int EmployeeId { get; set; }


        //Defining string length for the EmployeeName to be 50. 
        [StringLength(50)]
        //Declaring field EmployeeName as Required to specify it to be mandatory.
        [Required]
        //Defining datatype for EmployeeName to be as varchar.
        [Column(TypeName = "varchar")]
        //Defining EmployeeName to be of return type string.
        public string EmployeeName { get; set; }


        //Defining string length for the EmployeeDesignation to be 50. 
        [StringLength(50)]
        //Declaring field EmployeeDesignation as Required to specify it to be mandatory.
        [Required]
        //Defining datatype for EmployeeDesignation to be as varchar.
        [Column(TypeName = "varchar")]
        //Defining EmployeeDesignation to be of return type string.
        public string EmployeeDesignation { get; set; }

    }
}
