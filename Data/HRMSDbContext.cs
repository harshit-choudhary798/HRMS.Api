
using HRMS.Api.Models;
using Microsoft.EntityFrameworkCore;


namespace HRMS.Api.Data
{
public class HRMSDbContext: DbContext
{
        public HRMSDbContext(DbContextOptions<HRMSDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
