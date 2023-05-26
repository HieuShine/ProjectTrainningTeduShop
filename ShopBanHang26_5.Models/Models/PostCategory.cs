using ShopBanHang26_5.Models.Abstruct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("PostCategories")]
    public class PostCategory :AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public string DisplayOrder { get; set; }
        public string Image { get; set; }
        public int? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
