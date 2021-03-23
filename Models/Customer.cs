using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}
