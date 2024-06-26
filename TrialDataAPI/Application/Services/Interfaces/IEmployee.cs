﻿using TrialDataAPI.Domain.DTOs;
using TrialDataAPI.Domain.Models;

namespace TrialDataAPI.Application.Services.Interfaces
{
    public interface IEmployee
    {
        Employee Create(Employee employee);
        IEnumerable<EmployeeDTO> GetAll(int pageNumber, int qnty);
        Employee? GetById(int id);
        Employee Update(Employee employee);
        void Delete(int id);
    }   
}
