using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Customer_id { get; set; }
        public int Product_id { get; set; }
        public DateTime Purchase_date { get; set; }
    }
}
