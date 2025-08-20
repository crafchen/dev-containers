using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
     public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}