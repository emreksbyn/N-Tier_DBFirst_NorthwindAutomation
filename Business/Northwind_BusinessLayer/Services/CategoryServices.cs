using Northwind_BusinessLayer.Common;
using Northwind_BusinessLayer.Dtos;
using Northwind_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Northwind_BusinessLayer.Services
{
    public class CategoryServices
    {
        NorthwindEntities db = new NorthwindEntities();
        CategoryResponseModel retVal = new CategoryResponseModel();

        public CategoryResponseModel AddCategory(CategoryDto category)
        {

            try
            {
                var addCategory = MapDtoToCategory(category);
                db.Categories.Add(addCategory);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public CategoryResponseModel DeleteCategory(CategoryDto category)
        {
            try
            {
                var deleteCategory = MapDtoToCategory(category);
                db.Categories.Remove(deleteCategory);
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }
        public CategoryResponseModel UpdateCategory(Categories category)
        {
            try
            {
                Categories updateCategory = db.Categories.Where(x => x.CategoryID == category.CategoryID).FirstOrDefault();
                updateCategory = category;
                retVal.EffectiveCount = db.SaveChanges();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        public CategoryResponseModel GetAllCategory()
        {
            try
            {
                retVal.Categories = db.Categories.Select(x => new CategoryDto
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    Description = x.Description
                }).ToList();
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }


        public CategoryResponseModel GetCategoryById(int id)
        {
            try
            {
                var category = db.Categories.Where(x => x.CategoryID == id).Select(s => new CategoryDto
                {
                    CategoryID = s.CategoryID,
                    CategoryName = s.CategoryName,
                    Description = s.Description
                }).ToList();
                retVal.Categories = category;
            }
            catch (Exception ex)
            {
                retVal.IsValid = false;
                retVal.ErrorMessage = ex.Message;
            }
            return retVal;
        }

        private static Categories MapDtoToCategory(CategoryDto dto)
        {
            return new Categories
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description,
            };
        }

        private static CategoryDto MapCategoryToDto(Categories category)
        {
            return new CategoryDto
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
            };
        }
    }
}
