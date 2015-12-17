using System;
using System.Collections.Generic;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Services
{
    public interface ICategoryManagementService : IDisposable
    {
        IEnumerable<Category> GetAllCategories();
        void Add(Category category);
        void Update(Category category);
        Category GetCategory(int categoryId);
        void Delete(Category category);
    }
}