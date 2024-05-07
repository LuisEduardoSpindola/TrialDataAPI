using System.ComponentModel.DataAnnotations;

namespace TrialDataAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string? Photo { get; set; }
    }
}
