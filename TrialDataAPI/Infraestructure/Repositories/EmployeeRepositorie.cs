using System;
using System.Collections.Generic;
using System.Linq;
using TrialDataAPI.Infraestructure.Data;
using TrialDataAPI.Domain.Models;
using TrialDataAPI.Application.Services.Interfaces;

namespace TrialDataAPI.Infraestructure.Services.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        private readonly MainContext _context;

        public EmployeeRepository(MainContext context)
        {
            _context = context;
        }

        public Employee Create(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _context.employees.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        public IEnumerable<Employee> GetAll(int pageNumber, int qnty)
        {
            return _context.employees.Skip(pageNumber * qnty).Take(qnty).ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.employees.Find(id);
        }

        public void Delete(int id)
        {
            var employeeToDelete = _context.employees.Find(id);
            if (employeeToDelete != null)
            {
                _context.employees.Remove(employeeToDelete);
                _context.SaveChanges();
            }
        }

        public Employee Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            var existingEmployee = _context.employees.Find(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Age = employee.Age;
                existingEmployee.Photo = employee.Photo;

                _context.SaveChanges();
            }

            return existingEmployee;
        }
    }
}
