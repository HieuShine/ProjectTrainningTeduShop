using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface ISupportOnlineRepository:IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository:RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        
        }
    }
}
