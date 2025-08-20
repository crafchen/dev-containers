using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }

        // Quan hệ 1-n
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}