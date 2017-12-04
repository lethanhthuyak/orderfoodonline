using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class LichSuThanhToan:BaseEntity
    {
        public string MaKhachHang { get; set; }
        public string MaNhaHang { get; set; }
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public int TongTien { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
