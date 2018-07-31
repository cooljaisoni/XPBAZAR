using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPBAZAR.DBContext;
using XPBAZAR.Models;

namespace XPBAZAR.Repository
{
    public class ProudctRepository :IProudctRepository
    {

        private readonly MainDbContext _mainDbContext;


        public ProudctRepository(MainDbContext context)
        {
            _mainDbContext = context;
        }

        public IEnumerable<Models.Product> GetAllProducts()
        {
            var products = _mainDbContext.Product.Select(c => new Product
            {
                ProductId = c.ProductId,
                Name = c.Name,
                Description = c.Description,
                CategoryId = c.CategoryId,
                Amount = c.Amount,
                Quantity = c.Quantity,
                Photo=c.Photo
                

            }).ToList();

            return products;
        }

        public void Save()
        {

        }
        public void Update()
        {

        }
       public  void Delete()
        {

        }
    }
}
