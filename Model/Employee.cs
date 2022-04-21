using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Model
{
   
        [Table("Employee")]
        public class Employee
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }
    }

