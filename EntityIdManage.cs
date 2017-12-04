using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class EntityIdManage : BaseEntity
    {
        public string Name { get; set; }
        public int CurrentID { get; set; }
    }
}
