using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        public int Id { get; set; }
    }
}
