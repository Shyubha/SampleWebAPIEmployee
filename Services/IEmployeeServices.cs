using SampleWebAPIEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetAllEmployee();
        int AddEmployee(Employee emp);
        int ModifyEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
