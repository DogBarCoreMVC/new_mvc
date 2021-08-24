using Microsoft.EntityFrameworkCore;
using new_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_mvc.DataConnect
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Employee> EmployeesTbl { get; set; }
    }
}
