using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IPostRepository:IRepository<Post>
    {
        Post GetPostById(int id);
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex,int pageSize,out int totalRow);

    }
    public class PostRepository:RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {

            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.Id equals pt.PostId
                        where pt.TagId == tag && p.Status
                        orderby p.CreatedBy  descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex -1)*pageSize).Take(pageSize);
            return query.ToList();
        }

        public Post GetPostById(int id)
        {
            return this.DbContext.Posts.Where(x=>x.Id== id).FirstOrDefault();
        }
    }
}
