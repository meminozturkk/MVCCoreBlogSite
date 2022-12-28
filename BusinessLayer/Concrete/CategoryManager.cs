using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryReporsitory efCategoryReporsitory;
        public CategoryManager()
        {
            efCategoryReporsitory= new EfCategoryReporsitory();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryReporsitory.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryReporsitory.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryReporsitory.Update(category);
        }

        public List<Category> GetAll()
        {
           return efCategoryReporsitory.GetAllList();
        }

        public Category GetByID(int id)
        {
            return efCategoryReporsitory.GetbyID(id);
        }
    }
}
