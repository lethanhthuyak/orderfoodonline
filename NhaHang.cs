using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class NhaHang:BaseEntity
    {
        public string TenNhaHang { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public int GioMoCua { get; set; }
        public int GioDongCua { get; set; }
        public string SoDT { get; set; }
        public int LuotXem { get; set; }
        public int SoDiem { get; set; }
        public string MaKhuVuc { get; set; }
    }
}
