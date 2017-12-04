using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class GioHang : BaseEntity
    {
        public string TenMonAn { get; set; }
        public string MaKhachHang { get; set; }
        public string MaMonAn { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
    }
}
