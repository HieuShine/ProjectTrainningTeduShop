using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Repository.Interfraststructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDbContext Init();
    }
}
