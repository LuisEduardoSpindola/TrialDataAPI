using Microsoft.EntityFrameworkCore;
using TrialDataAPI.Models;

namespace TrialDataAPI.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> employees { get; set; }
    }
}
