using SampleWebAPIEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        int AddEmployee(Employee emp);
        int ModifyEmployee(Employee prod);
        int DeleteEmployee(int id);
    }
}
    