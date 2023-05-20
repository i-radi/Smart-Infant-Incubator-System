﻿namespace Domain.Dtos.EmployeeDtos;

public class EmployeeReadDto : ReadDto<Employee>
{
    public Guid Id { get; set; }
    public string University { get; set; } = null!;
    public string DegreeOfPromotion { get; set; } = null!;
    public string Specialization { get; set; } = null!;
}