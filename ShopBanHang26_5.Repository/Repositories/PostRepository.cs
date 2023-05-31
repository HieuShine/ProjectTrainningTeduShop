using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IPostRepository
    {
        Post GetPostById(int id);

    }
    public class PostRepository:RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Post GetPostById(int id)
        {
            return this.DbContext.Posts.Where(x=>x.Id== id).FirstOrDefault();
        }
    }
}
