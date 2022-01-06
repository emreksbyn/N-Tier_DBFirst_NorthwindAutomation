using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Northwind_BusinessLayer.Services
{
    public class ShipperServices
    {
        NorthwindEntities db = new NorthwindEntities();
        ShipperResponseModel retVal = new ShipperResponseModel();

        public ShipperResponseModel AddShipper(ShipperDto shipper)
        {
            try
            {
                var addShipper = MapDtoToShipper(shipper);
                db.Shippers.Add(addShipper);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ShipperResponseModel DeleteShipper(ShipperDto shipper)
        {
            try
            {
                var deleteShipper = MapDtoToShipper(shipper);
                db.Shippers.Remove(deleteShipper);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ShipperResponseModel UpdateShipper(Shippers shipper)
        {
            try
            {
                Shippers updateShipper = db.Shippers.Where(x => x.ShipperID == shipper.ShipperID).FirstOrDefault();

                updateShipper = shipper;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ShipperResponseModel GetAllShippers()
        {
            try
            {
                retVal.Shippers = db.Shippers.Select(x => new ShipperDto
                {
                    ShipperID = x.ShipperID,
                    CompanyName = x.CompanyName,
                    Phone = x.Phone
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ShipperResponseModel GetShipperById(int id)
        {
            try
            {                
                retVal.Shippers = db.Shippers.Where(x => x.ShipperID == id).Select(s => new ShipperDto
                {
                    ShipperID = s.ShipperID,
                    CompanyName = s.CompanyName,
                    Phone = s.Phone

                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Shippers MapDtoToShipper(ShipperDto dto)
        {
            return new Shippers
            {
                CompanyName = dto.CompanyName,
                Phone = dto.Phone
            };
        }

        private static ShipperDto MapShipperToDto(Shippers shipper)
        {
            return new ShipperDto
            {

                CompanyName = shipper.CompanyName,
                Phone = shipper.Phone
            };
        }

    }
}

