using Microsoft.AspNetCore.Mvc;
using SampleWebAPIEmployee.Model;
using SampleWebAPIEmployee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _empservice;
        public EmployeeController(IEmployeeServices empservice)
        {
            _empservice = empservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IActionResult GetEmployee()
        {
            return new ObjectResult(_empservice.GetAllEmployee());
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddProduct(Employee emp)
        {
            return new ObjectResult(_empservice.AddEmployee(emp));
        }

        [HttpPost]
        [Route("ModifyProduct")]
        public IActionResult ModifyProduct(Employee emp)
        {
            return new ObjectResult(_empservice.ModifyEmployee(emp));
        }

        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return new ObjectResult(_empservice.DeleteEmployee(id));
        }




    }
}

    
