using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class DonDatHang:BaseEntity
    {
        public string MaKhachHang { get; set; }
        public DateTime NgayThang { get; set; }
        public DateTime NgayGioGiao { get; set; }
        public string DiaChiGiao { get; set; }
        public string SoDienThoai { get; set; }
        public string HinhThucThanhToan { get; set; }
        public int TongTien { get; set; }
        public string CTDonDatHang { get; set; }
        public bool DaXacNhan{ get; set; }
        public bool DaGiaoDich { get; set; }
    }
}
