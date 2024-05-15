using AutoMapper;
using TrialDataAPI.Domain.DTOs;
using TrialDataAPI.Domain.Models;

namespace TrialDataAPI.Domain.Mapping;

public class DTOMapping : Profile
{
    public DTOMapping()
    {
        CreateMap<Employee, EmployeeDTO>();
    
        // Como os nomes dos atributos do modelo e do DTO são iguais não será necessário fazer mais alterações
    }
}