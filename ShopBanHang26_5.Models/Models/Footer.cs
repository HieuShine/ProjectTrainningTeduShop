using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }
        
    }
}
