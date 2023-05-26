using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post Posts { get; set; }
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { get; set; }
        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}
