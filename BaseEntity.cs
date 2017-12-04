using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public bool Active { get; set; }
        public string UpdateBy { get; set; }

    }
}
