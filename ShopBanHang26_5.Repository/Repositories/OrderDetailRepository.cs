using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetById(int id);
    }
    public class OrderDetailRepository:RepositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

        public OrderDetail GetById(int id)
        {
            return this.DbContext.OrderDetails.Where(x=>x.OrderId== id).FirstOrDefault();
        }
    }
}
