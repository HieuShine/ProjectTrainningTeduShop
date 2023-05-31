using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IPostCategoryRepository
    {
        PostCategory GetPostCategoryById(int id);
    }
    public class PostCategoryRepository:RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

        public PostCategory GetPostCategoryById(int id)
        {
            return this.DbContext.PostCategories.Where(x=>x.Id== id).FirstOrDefault();
        }
    }
}
