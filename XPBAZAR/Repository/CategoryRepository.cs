using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPBAZAR.DBContext;
using XPBAZAR.Models;


namespace XPBAZAR.Repository
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly MainDbContext _mainDbContext;


        public CategoryRepository(MainDbContext context)
        {
            _mainDbContext = context;
        }

        public IEnumerable<Models.Category> GetAllCategories()
        {
            var categories = _mainDbContext.Category.Select(c => new Category
            {
                CategoryId = c.CategoryId,
                Name = c.Name,
            }).ToList();

            return categories;
        }
    }
}
