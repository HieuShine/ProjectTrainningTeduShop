using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface ISlide:IRepository<Slide>
    {

    }
    public class SlideRepository:RepositoryBase<Slide>, ISlide
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
