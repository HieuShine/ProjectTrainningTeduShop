using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using ShopBanHang26_5.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Service.PostService
{
    public class PostService : IPostService
    {
        IPostRepository _IPostRepository;
        IUnitOfWork _UnitOfWork;

        public PostService(IPostRepository iPostRepository, UnitOfWork unitOfWork)
        {
            _IPostRepository = iPostRepository;
            _UnitOfWork = unitOfWork;
        }


        public void Add(Post Post)
        {
            _IPostRepository.Add(Post);

        }

        public void Delete(Post Post)
        {
            _IPostRepository.Delete(Post);
        }

        public void DeleteById(int id)
        {
            _IPostRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _IPostRepository.GetAll(new string []{ "PostCategory"} );
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _IPostRepository.GetAllByTag(tag,page,pageSize,out totalRow);
        }

       

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _IPostRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _IPostRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _UnitOfWork.Commit();
        }

        public void Update(Post Post)
        {
            _IPostRepository.Update(Post);
        }
    }
}
