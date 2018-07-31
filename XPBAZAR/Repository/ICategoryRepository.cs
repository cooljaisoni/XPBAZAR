using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XPBAZAR.Models;
namespace XPBAZAR.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
