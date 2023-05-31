using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface ITag
    {
        Tag GetById(int id);
    }
    public class TagRepository:RepositoryBase<Tag>, ITag
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Tag GetById(int id)
        {
            return this.DbContext.Tags.Where(x=>x.Id == id).FirstOrDefault();
        }
    }
}
