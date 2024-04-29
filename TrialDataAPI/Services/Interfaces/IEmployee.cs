using TrialDataAPI.Models;

namespace TrialDataAPI.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee Create(Employee employee);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Update(Employee employee);
        void Delete(int id);
    }   
}
