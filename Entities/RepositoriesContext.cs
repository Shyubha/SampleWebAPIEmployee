using Microsoft.EntityFrameworkCore;
using SampleWebAPIEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebAPIEmployee.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
