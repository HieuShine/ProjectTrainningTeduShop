﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBanHang26_5.Models.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int ValueInt { get; set; }
    }
}
