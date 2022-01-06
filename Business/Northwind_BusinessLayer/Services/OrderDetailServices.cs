using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class OrderDetailServices
    {
        NorthwindEntities db = new NorthwindEntities();
        OrderDetailResponseModel retVal = new OrderDetailResponseModel();


        public OrderDetailResponseModel GetAllOrderDetails()
        {
            try
            {
                retVal.OrderDetails = db.Order_Details.Select(x => new OrderDetailDto
                {
                    OrderID = x.OrderID,
                    ProductID = x.ProductID,
                    Discount = x.Discount,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        public OrderDetailResponseModel GetOrderDetailByOrderId(int id)
        {
            try
            {
                retVal.OrderDetails = db.Order_Details.Where(x => x.OrderID == id).Select(s => new OrderDetailDto
                {
                    OrderID = s.OrderID,
                    UnitPrice = s.UnitPrice,
                    Quantity = s.Quantity,
                    ProductID = s.ProductID,
                    Discount = s.Discount
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Order_Details MapDtoToOrderDetail(OrderDetailDto dto)
        {
            return new Order_Details
            {
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity,
                Discount = dto.Discount,
                ProductID = dto.ProductID
            };
        }
        private static OrderDetailDto MapOrderDetailToDto(Order_Details orderDetails)
        {
            return new OrderDetailDto
            {
                UnitPrice = orderDetails.UnitPrice,
                Quantity = orderDetails.Quantity,
                Discount = orderDetails.Discount,
                ProductID = orderDetails.ProductID
            };
        }
    }
}