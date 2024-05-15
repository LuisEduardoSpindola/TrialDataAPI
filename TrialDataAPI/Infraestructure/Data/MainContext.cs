using Microsoft.EntityFrameworkCore;
using TrialDataAPI.Domain.Models;

namespace TrialDataAPI.Infraestructure.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> employees { get; set; }
    }
}
