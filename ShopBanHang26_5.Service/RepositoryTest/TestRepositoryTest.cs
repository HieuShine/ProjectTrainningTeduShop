using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using ShopBanHang26_5.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Service.RepositoryTest
{
    [TestClass]
    public  class TestRepositoryTest
    {
        IDbFactory _dbFactory;
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        [TestInitialize]
        public void Inutialize() {
            _dbFactory = new DbFactory();
            _postCategoryRepository = new PostCategoryRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);
        }
        [TestMethod]
        public void PostRepository_Getall()
        {
            var list = _postCategoryRepository.GetAll().ToList();
            Assert.IsNotNull(list);
        }
        [TestMethod]    
        public void PostRepository_Create_Test()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name= "Test Category";
            postCategory.Alias= "Test-alias";
            postCategory.Status = true;

            var result = _postCategoryRepository.Add(postCategory);
            _unitOfWork.Commit(); //commit nếu đúng ra id=1
            Assert.AreEqual(1,result.Id); //kiểm tra giá trị đầu vào nếu lỗi hoặc đầu vào = false thì hiển thị thông báo lỗi
            Assert.IsNotNull(result);                           // và abort() kết thúc chương trình



        }

    }
}
