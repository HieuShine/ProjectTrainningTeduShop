using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Interfraststructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ShopDbContext dbContext;
        public ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext!=null)
            {
                dbContext.Dispose();
            }
        }
    }
}
