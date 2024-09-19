using Microsoft.EntityFrameworkCore;
using Task_4_EntityFramework.Models;

namespace Task_4_EntityFramework.Data
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Employee>Employee {  get; set; }
       
    }
}
