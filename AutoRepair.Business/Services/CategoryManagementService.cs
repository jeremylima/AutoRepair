using System.Collections.Generic;
using System.Linq;
using AutoRepair.Business.Models;
using AutoRepair.DataAccess.Infrastructure;
using CustomExceptions;

namespace AutoRepair.Business.Services
{
    public class CategoryManagementService : ICategoryManagementService
    {
        private readonly IIntKeyedRepository<DataAccess.Entities.Category> _categoryRepository;

        public CategoryManagementService(IIntKeyedRepository<DataAccess.Entities.Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }

        public void Dispose()
        {
            _categoryRepository.Dispose();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.All().Select(AutoMapper.Mapper.Map<DataAccess.Entities.Category, Category>);
        }

        public void Add(Category category)
        {
            var _category = _categoryRepository.FindBy(x => x.Name == category.Name);
            if(_category != null)
                throw new DuplicatedEntryKeyException();

            _categoryRepository.Add(AutoMapper.Mapper.Map<Category, DataAccess.Entities.Category>(category));
        }

        public void Update(Category category)
        {
            var _category = _categoryRepository.FindBy(x => x.Name == category.Name);
            if (_category != null)
            {
                if (_category.Id != category.Id)
                    throw new DuplicatedEntryKeyException();
            }

            _categoryRepository.Update(AutoMapper.Mapper.Map<Category, DataAccess.Entities.Category>(category));
        }

        public Category GetCategory(int categoryId)
        {
            var category = _categoryRepository.FindBy(categoryId);
            return AutoMapper.Mapper.Map<DataAccess.Entities.Category, Category>(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(AutoMapper.Mapper.Map<Category, DataAccess.Entities.Category>(category));
        }

        
    }
}