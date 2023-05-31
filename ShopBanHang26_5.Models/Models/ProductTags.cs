using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("ProductTags")]
    public class ProductTags
    {
        [Key]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tags { get; set; }

    }
}
