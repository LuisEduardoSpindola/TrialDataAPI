using TrialDataAPI.Models;

namespace TrialDataAPI.Services.Interfaces
{
    public interface IEmployee
    {
        Employee Create(Employee employee);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Update(Employee employee);
        void Delete(int id);
    }   
}
