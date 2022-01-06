using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Northwind_BusinessLayer.Services
{
    public class CustomerServices
    {
        NorthwindEntities db = new NorthwindEntities();
        CustomerResponseModel retVal = new CustomerResponseModel();

        public CustomerResponseModel AddCustomer(CustomerDto customer)
        {
            try
            {
                var addCustomer = MapDtoToCustomer(customer);
                db.Customers.Add(addCustomer);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public CustomerResponseModel DeleteCustomer(CustomerDto customer)
        {
            try
            {
                var deleteCustomer = MapDtoToCustomer(customer);
                db.Customers.Remove(deleteCustomer);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public CustomerResponseModel UpdateCustomer(Customers customer)
        {
            try
            {
                Customers updateCustomer = db.Customers.Where(x => x.CustomerID == customer.CustomerID).FirstOrDefault();
                updateCustomer = customer;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public CustomerResponseModel GetAllCustomers()
        {
            try
            {
                retVal.Customers = db.Customers.Select(x => new CustomerDto
                {
                    CustomerID = x.CustomerID,
                    Region = x.Region,
                    PostalCode = x.PostalCode,
                    Address = x.Address,
                    City = x.City,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                    Country = x.Country,
                    Fax = x.Fax,
                    Phone = x.Phone,
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        // id string dikkat et
        public CustomerResponseModel GetCustomerById(string id)
        {
            try
            {
                var customer = db.Customers.Where(x => x.CustomerID == id).Select(s => new CustomerDto
                {
                    CustomerID = s.CustomerID,
                    Address = s.Address,
                    City = s.City,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle,
                    Phone = s.Phone,
                    Region = s.Region,
                    Country = s.Country,
                    Fax = s.Fax,
                    PostalCode = s.PostalCode
                }).ToList();
                retVal.Customers = customer;
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Customers MapDtoToCustomer(CustomerDto dto)
        {
            return new Customers
            {
                Address = dto.Address,
                City = dto.City,
                CompanyName = dto.CompanyName,
                ContactName = dto.ContactName,
                ContactTitle = dto.ContactTitle,
                Country = dto.Country,
                Phone = dto.Phone,
                PostalCode = dto.PostalCode,
                Region = dto.Region,
                Fax = dto.Fax
            };
        }
        private static CustomerDto MapCustomerToDto(Customers customer)
        {
            return new CustomerDto
            {
                CompanyName = customer.CompanyName,
                Address = customer.Address,
                Fax = customer.Fax,
                ContactName = customer.ContactName,
                City = customer.City,
                ContactTitle = customer.ContactTitle,
                Country = customer.Country,
                Phone = customer.Phone,
                PostalCode = customer.PostalCode,
                Region = customer.Region
            };
        }
    }
}
