using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class KhachHang : BaseEntity
    {
        [Required(ErrorMessage = "Ho ten khong duoc rong")]
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh{ get; set; }
        [Required(ErrorMessage = "Email khong duoc rong")]
        //[EmailAddress(ErrorMessage = "Email khong hop le")]
        public string Email { get; set; }
        [Required(ErrorMessage = "So dien thoai khong duoc rong")]
        public int SoDT { get; set; }
        [Required(ErrorMessage = "Dia chi khong duoc rong")]
        public string DiaChi { get; set; }
        public string MaKhuVuc { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int TichDiem { get; set; }
    }
}
