using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class NhanVien:BaseEntity
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public string Email { get; set; }
        public string SoDT { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string MaNhaHang { get; set; }
    }
}
