using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class PhieuGiaoHang:BaseEntity
    {
        public string MaKhachHang { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime NgayThang { get; set; }
        public int TongTien { get; set; }
    }
}
