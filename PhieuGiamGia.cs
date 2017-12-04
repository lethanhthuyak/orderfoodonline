using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class PhieuGiamGia: BaseEntity
    {
        
        public string MaMonAn { get; set; }
        public float ChietKhau { get; set; }
        public DateTime BatDau { get; set; }
        public DateTime KetThuc { get; set; }
    }
}
