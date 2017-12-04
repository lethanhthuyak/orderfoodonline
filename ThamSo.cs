using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class ThamSo:BaseEntity
    {
        public string TenThamSo { get; set; }
        public string GiaTri { get; set; }
        public string GhiChu { get; set; }
    }
}
