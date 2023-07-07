using ShopBanHang26_5.Models.Models;
using ShopBanHang26_5.Repository.Interfraststructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
        //IEnumerable<Order> GetById(int Id);
        Order GetById(int id);
    }
    public class OrderRepository:RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Order GetById(int id)
        {
            return this.DbContext.Orders.Where(x=>x.Id == id).FirstOrDefault();
        }
    }
}
