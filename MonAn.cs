using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class MonAn:BaseEntity
    {
        public string TenMonAn { get; set; }
        public string MaLoai { get; set; }
        public int DonGia { get; set; }
        public string MaNhaHang { get; set; }
        public string HinhAnh { get; set; }
        public int SoDiem { get; set; }
        public int SoLuong { get; set; }
        public string NguyenLieu { get; set; }
        public string Protein { get; set; }
        public string NangLuong { get; set; }
        public string MoTa { get; set; }
        public string TenNhaHang { get; set; }
    }
}
