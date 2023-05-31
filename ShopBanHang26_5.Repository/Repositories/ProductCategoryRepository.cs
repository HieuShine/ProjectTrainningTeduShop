using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IProductCategoryRepository
    {
        ProductCategory GetProductCategoryById(int id);
    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory) 
        {
            
        }

        public ProductCategory GetProductCategoryById(int id)
        {
           return this.DbContext.ProductCategories.Where(x=>x.Id== id).FirstOrDefault();
        }
    }
}
