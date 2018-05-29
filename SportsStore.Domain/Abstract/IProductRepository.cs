using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Abstract
{
    interface IProductRepository
    {
        IEnumerable<Product> Products { get; set; }
    }
}
