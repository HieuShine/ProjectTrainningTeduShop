using ShopBanHang26_5.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Service.PostService
{
    public interface IPostService
    {
        void Add(Post Post);
        void Delete(Post Post);
        void Update(Post Post);
        IEnumerable<Post> GetAll();
        //IEnumerable<Post> GetById(int id);
        IEnumerable<Post> GetAllPaging(int page,int pageSize,out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page,int pageSize,out int totalRow);
        void SaveChanges();
        void DeleteById(int id);

    }
}
