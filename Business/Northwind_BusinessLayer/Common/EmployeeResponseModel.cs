using Northwind_BusinessLayer.Dtos;
using System.Collections.Generic;

namespace Northwind_BusinessLayer.Common
{
    public class EmployeeResponseModel
    {
        public int EffectiveCount { get; set; }
        public List<EmployeeDto> Employees { get; set; }
        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}
