using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
    }
    public class ProductRepository:RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        { 
        
        }

        public Product GetProductById(int id)
        {
            return this.DbContext.Products.Where(x=>x.Id == id).FirstOrDefault();
        }
    }
}
