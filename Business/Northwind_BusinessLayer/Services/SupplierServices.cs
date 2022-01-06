using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class SupplierServices
    {
        NorthwindEntities db = new NorthwindEntities();
        SupplierResponseModel retVal = new SupplierResponseModel();

        public SupplierResponseModel AddSupllier(SupplierDto supplier)
        {
            try
            {
                var addSupplier = MapDtoToSupplier(supplier);
                db.Suppliers.Add(addSupplier);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public SupplierResponseModel DeleteSupplier(SupplierDto supplier)
        {
            try
            {
                var deleteSupplier = MapDtoToSupplier(supplier);
                db.Suppliers.Remove(deleteSupplier);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public SupplierResponseModel UpdateSupplier(Suppliers supplier)
        {
            try
            {
                Suppliers updateSupplier = db.Suppliers.Where(x => x.SupplierID == supplier.SupplierID).FirstOrDefault();

                updateSupplier = supplier;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public SupplierResponseModel GetAllSuppliers()
        {
            try
            {
                retVal.Suppliers = db.Suppliers.Select(x => new SupplierDto
                {
                    SupplierID = x.SupplierID,
                    Address = x.Address,
                    City = x.City,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                    Country = x.Country,
                    Fax = x.Fax,
                    Phone = x.Phone,
                    PostalCode = x.PostalCode,
                    Region = x.Region
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public SupplierResponseModel GetSupplierById(int id)
        {
            try
            {
                retVal.Suppliers = db.Suppliers.Where(x => x.SupplierID == id).Select(s => new SupplierDto
                {
                    SupplierID = s.SupplierID,
                    Address = s.Address,
                    City = s.City,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle,
                    Country = s.Country,
                    Fax = s.Fax,
                    Phone = s.Phone,
                    PostalCode = s.PostalCode,
                    Region = s.Region

                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Suppliers MapDtoToSupplier(SupplierDto dto)
        {
            return new Suppliers
            {
                Address = dto.Address,
                City = dto.City,
                CompanyName = dto.CompanyName,
                ContactName = dto.ContactName,
                ContactTitle = dto.ContactTitle,
                Country = dto.Country,
                Fax = dto.Fax,
                Phone = dto.Phone,
                PostalCode = dto.PostalCode,
                Region = dto.Region
            };
        }
        private static SupplierDto MapSupplierToDto(Suppliers supplier)
        {
            return new SupplierDto
            {
                Address = supplier.Address,
                City = supplier.City,
                CompanyName = supplier.CompanyName,
                ContactName = supplier.ContactName,
                ContactTitle = supplier.ContactTitle,
                Country = supplier.Country,
                Fax = supplier.Fax,
                Phone = supplier.Phone,
                PostalCode = supplier.PostalCode,
                Region = supplier.Region
            };
        }
    }
}