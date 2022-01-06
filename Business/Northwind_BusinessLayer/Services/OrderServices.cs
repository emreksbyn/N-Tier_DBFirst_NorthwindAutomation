using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class OrderServices
    {
        NorthwindEntities db = new NorthwindEntities();
        OrderResponseModel retVal = new OrderResponseModel();

        public OrderResponseModel AddOrder(OrderDto order)
        {
            try
            {
                var addOrder = MapDtoToOrder(order);
                db.Orders.Add(addOrder);
                retVal.EffectiveCount = db.SaveChanges();

            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public OrderResponseModel DeleteOrder(OrderDto order)
        {
            try
            {
                var deleteOrder = MapDtoToOrder(order);
                db.Orders.Remove(deleteOrder);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public OrderResponseModel UpdateOrder(Orders order)
        {
            try
            {
                Orders updateOrder = db.Orders.Where(x => x.OrderID == order.OrderID).FirstOrDefault();

                updateOrder = order;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public OrderResponseModel GetAllOrders()
        {
            try
            {
                retVal.Orders = db.Orders.Select(x => new OrderDto
                {
                    OrderID = x.OrderID,
                    CustomerID = x.CustomerID,
                    EmployeeID = x.EmployeeID,
                    OrderDate = x.OrderDate,
                    RequiredDate = x.RequiredDate,
                    ShippedDate = x.ShippedDate,
                    ShipVia = x.ShipVia,
                    Freight = x.Freight,
                    ShipName = x.ShipName,
                    ShipAddress = x.ShipAddress,
                    ShipCity = x.ShipCity,
                    ShipRegion = x.ShipRegion,
                    ShipPostalCode = x.ShipPostalCode,
                    ShipCountry = x.ShipCountry
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public OrderResponseModel GetOrderById(int id)
        {
            try
            {
                retVal.Orders = db.Orders.Where(x => x.OrderID == id).Select(s => new OrderDto
                {
                    CustomerID = s.CustomerID,
                    EmployeeID = s.EmployeeID,
                    OrderDate = s.OrderDate,
                    RequiredDate = s.RequiredDate,
                    ShippedDate = s.ShippedDate,
                    ShipVia = s.ShipVia,
                    Freight = s.Freight,
                    ShipName = s.ShipName,
                    ShipAddress = s.ShipAddress,
                    ShipCity = s.ShipCity,
                    ShipRegion = s.ShipRegion,
                    ShipPostalCode = s.ShipPostalCode,
                    ShipCountry = s.ShipCountry
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Orders MapDtoToOrder(OrderDto dto)
        {
            return new Orders
            {
                CustomerID = dto.CustomerID,
                EmployeeID = dto.EmployeeID,
                OrderDate = dto.OrderDate,
                RequiredDate = dto.RequiredDate,
                ShippedDate = dto.ShippedDate,
                ShipVia = dto.ShipVia,
                Freight = dto.Freight,
                ShipName = dto.ShipName,
                ShipAddress = dto.ShipAddress,
                ShipCity = dto.ShipCity,
                ShipRegion = dto.ShipRegion,
                ShipPostalCode = dto.ShipPostalCode,
                ShipCountry = dto.ShipCountry
            };
        }

        private static OrderDto MapOrderToDto(Orders orders)
        {
            return new OrderDto
            {

                CustomerID = orders.CustomerID,
                EmployeeID = orders.EmployeeID,
                OrderDate = orders.OrderDate,
                RequiredDate = orders.RequiredDate,
                ShippedDate = orders.ShippedDate,
                ShipVia = orders.ShipVia,
                Freight = orders.Freight,
                ShipName = orders.ShipName,
                ShipAddress = orders.ShipAddress,
                ShipCity = orders.ShipCity,
                ShipRegion = orders.ShipRegion,
                ShipPostalCode = orders.ShipPostalCode,
                ShipCountry = orders.ShipCountry
            };
        }
    }
}