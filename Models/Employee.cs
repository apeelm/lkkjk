using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage ="* Name can't be blank")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* State can't be blank")]
        public string State { get; set; }
        [Required(ErrorMessage = "* Salary can't be blank")]
        public decimal Salary { get; set; }
    }
}
