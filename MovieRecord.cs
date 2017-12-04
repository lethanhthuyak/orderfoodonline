using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodOnline.Models.Entity
{
    public class MovieRecord : BaseEntity
    {
        public int movieId { get; set; }
        public string title { get; set; }
    }
}