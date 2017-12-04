using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class BinhLuan:BaseEntity
    {
        
        public string MaMonAn { get; set; }
        public string MaNhaHang { get; set; }
        public string MaKhachHang { get; set; }
        public string NoiDung { get; set; }

    }
}
