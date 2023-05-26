using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Abstruct
{
    public abstract class AuditTable : IAuditTable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set ; }
        [MaxLength(256)]
        public string UpdateBy { get ; set ; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDecription { get; set; }
        public bool Status { get; set; }
    }
}
