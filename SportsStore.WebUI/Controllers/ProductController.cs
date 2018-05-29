using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
        
    }
}