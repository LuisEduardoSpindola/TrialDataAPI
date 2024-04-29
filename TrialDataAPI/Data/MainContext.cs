using Microsoft.EntityFrameworkCore;
using TrialDataAPI.Models;

namespace TrialDataAPI.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) 
        {
        
        }

        DbSet<Employee> employees { get; set; }
    }
}
