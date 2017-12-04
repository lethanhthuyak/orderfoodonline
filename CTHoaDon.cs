﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class CTHoaDon : BaseEntity
    {
        public string MaHoaDon { get; set; }
        public string MaMonAn { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
    }
}
