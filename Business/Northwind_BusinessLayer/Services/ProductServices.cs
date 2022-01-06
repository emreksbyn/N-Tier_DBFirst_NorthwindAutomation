using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class ProductServices
    {
        NorthwindEntities db = new NorthwindEntities();
        ProductResponseModel retVal = new ProductResponseModel();

        public ProductResponseModel AddProduct(ProductDto product)
        {
            try
            {
                var addProduct = MapDtoToProduct(product);
                db.Products.Add(addProduct);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        public ProductResponseModel RemoveProduct(ProductDto product)
        {
            try
            {
                var deleteProduct = MapDtoToProduct(product);
                db.Products.Remove(deleteProduct);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ProductResponseModel UpdateProduct(Products product)
        {
            try
            {
                Products updateProduct = db.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                updateProduct = product;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ProductResponseModel GetAllProducts()
        {
            try
            {
                retVal.Products = db.Products.Select(x => new ProductDto
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    SupplierID = x.SupplierID,
                    CategoryID = x.CategoryID,
                    QuantityPerUnit = x.QuantityPerUnit,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    UnitsOnOrder = x.UnitsOnOrder,
                    ReorderLevel = x.ReorderLevel,
                    Discontinued = x.Discontinued

                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public ProductResponseModel GetProductById(int id)
        {
            try
            {
                retVal.Products = db.Products.Where(x => x.ProductID == id).Select(s => new ProductDto
                {
                    ProductID = s.ProductID,
                    ProductName = s.ProductName,
                    SupplierID = s.SupplierID,
                    CategoryID = s.CategoryID,
                    QuantityPerUnit = s.QuantityPerUnit,
                    UnitPrice = s.UnitPrice,
                    UnitsInStock = s.UnitsInStock,
                    UnitsOnOrder = s.UnitsOnOrder,
                    ReorderLevel = s.ReorderLevel,
                    Discontinued = s.Discontinued

                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Products MapDtoToProduct(ProductDto dto)
        {
            return new Products
            {
                ProductName = dto.ProductName,
                SupplierID = dto.SupplierID,
                CategoryID = dto.CategoryID,
                QuantityPerUnit = dto.QuantityPerUnit,
                UnitPrice = dto.UnitPrice,
                UnitsInStock = dto.UnitsInStock,
                UnitsOnOrder = dto.UnitsOnOrder,
                ReorderLevel = dto.ReorderLevel,
                Discontinued = dto.Discontinued
            };
        }

        private static ProductDto MapProductToDto(Products product)
        {
            return new ProductDto
            {
                ProductName = product.ProductName,
                SupplierID = product.SupplierID,
                CategoryID = product.CategoryID,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            };
        }

    }
}
