using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class HoaDon:BaseEntity
    {
        
        public string MaDonDatHang { get; set; }
        public string MaHinhThuc { get; set; }
        public DateTime NgayThang { get; set; }
        //public string MaMonAn { get; set; }
        //public int DonGia { get; set; }
        //public int SoLuong { get; set; }
        public int TongTien { get; set; }
    }
}
