using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange2.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
    }
}
