using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class EmployeeServices
    {
        NorthwindEntities db = new NorthwindEntities();
        EmployeeResponseModel retVal = new EmployeeResponseModel();
        public EmployeeResponseModel AddEmployee(EmployeeDto employee)
        {
            try
            {
                var addEmployee = MapDtoToEmployee(employee);
                db.Employees.Add(addEmployee);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }

            return retVal;
        }

        public EmployeeResponseModel DeteleEmployee(EmployeeDto employee)
        {
            try
            {
                var deleteEmployee = MapDtoToEmployee(employee);
                db.Employees.Remove(deleteEmployee);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        public EmployeeResponseModel UpdateEmployee(Employees employee)
        {
            try
            {
                Employees updateEmployee = db.Employees.Where(x => x.EmployeeID == employee.EmployeeID).FirstOrDefault();

                updateEmployee = employee;

                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public EmployeeResponseModel GetAllEmployees()
        {
            try
            {
                retVal.Employees = db.Employees.Select(x => new EmployeeDto
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = x.Address,
                    BirthDate = x.BirthDate,
                    City = x.City,
                    HireDate = x.HireDate,
                    Country = x.Country,
                    HomePhone = x.HomePhone,
                    Extension = x.Extension,
                    Notes = x.Notes,
                    PostalCode = x.PostalCode,
                    Region = x.Region,
                    ReportsTo = x.ReportsTo,
                    Title = x.Title
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        public EmployeeResponseModel GetEmployeeById(int id)
        {
            try
            {
                retVal.Employees = db.Employees.Where(x => x.EmployeeID == id).Select(s => new EmployeeDto
                {
                    EmployeeID = s.EmployeeID,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Address = s.Address,
                    BirthDate = s.BirthDate,
                    City = s.City,
                    HireDate = s.HireDate,
                    Country = s.Country,
                    HomePhone = s.HomePhone,
                    Extension = s.Extension,
                    Notes = s.Notes,
                    PostalCode = s.PostalCode,
                    Region = s.Region,
                    ReportsTo = s.ReportsTo,
                    Title = s.Title
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Employees MapDtoToEmployee(EmployeeDto dto)
        {
            return new Employees
            {
                Address = dto.Address,
                BirthDate = dto.BirthDate,
                City = dto.City,
                Country = dto.Country,
                Extension = dto.Extension,
                FirstName = dto.FirstName,
                HireDate = dto.HireDate,
                HomePhone = dto.HomePhone,
                LastName = dto.LastName,
                Notes = dto.Notes,
                PostalCode = dto.PostalCode,
                Region = dto.Region,
                ReportsTo = dto.ReportsTo,
                Title = dto.Title
            };
        }

        private static EmployeeDto MapEmployeeToDto(Employees employee)
        {
            return new EmployeeDto
            {
                Address = employee.Address,
                BirthDate = employee.BirthDate,
                City = employee.City,
                Country = employee.Country,
                Extension = employee.Extension,
                FirstName = employee.FirstName,
                HireDate = employee.HireDate,
                HomePhone = employee.HomePhone,
                LastName = employee.LastName,
                Notes = employee.Notes,
                PostalCode = employee.PostalCode,
                Region = employee.Region,
                ReportsTo = employee.ReportsTo,
                Title = employee.Title
            };
        }
    }
}
