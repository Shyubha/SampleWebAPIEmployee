using SampleWebAPIEmployee.Entities;
using SampleWebAPIEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        RepositoriesContext context;
        public EmployeeRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee emp)
        {
            context.Employee.Add(emp);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var emp = context.Employee.Where(e => e.Id == id).SingleOrDefault();
            if (emp != null)
            {
                context.Employee.Remove(emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employee.ToList();

        }

        public int ModifyEmployee(Employee emp)
        {

            var Employee = context.Employee.Where(e => e.Id == emp.Id).SingleOrDefault();
            if (Employee != null)
            {
                Employee.Name = emp.Name;
                Employee.Salary = emp.Salary;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }



    }

}
   
