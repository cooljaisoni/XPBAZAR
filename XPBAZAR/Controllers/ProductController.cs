using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XPBAZAR.Repository;
using XPBAZAR.Models;


namespace XPBAZAR.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private IProudctRepository _proudctRepository;

        public ProductController(IProudctRepository proudctRepository)
        {
            _proudctRepository = proudctRepository;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return _proudctRepository.GetAllProducts();
        }

    }
}