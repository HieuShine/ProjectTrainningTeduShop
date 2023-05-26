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
    [Table("Posts")]
    public class Post :AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [Required]
        public int PostCategoryId { get; set; }
        [ForeignKey(nameof(PostCategoryId))]
        public virtual PostCategory PostCategory { get; set; }
        //public ICollection<PostTag> PostTags { get; set; }
    }
}
