using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using ShopBanHang26_5.Repository.Repositories;
using ShopBanHang26_5.Service.PostCategoryService;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Service.ServiceTest
{
    [TestClass]
    public class PostServiceTest
    {
        private Mock<IPostCategoryRepository> _mockPostCategoryRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> lstCategory;
        public void innitiallize()
        {
            _mockPostCategoryRepository= new Mock<IPostCategoryRepository>();
            _mockUnitOfWork= new Mock<IUnitOfWork>();
            lstCategory= new List<PostCategory>();
        }
        [TestMethod]
        public void PostCategoryService_GetAll()
        {

        }
        [TestMethod]

        public void PostCategorySẻvice_Create()
        {

        }
    }
}
