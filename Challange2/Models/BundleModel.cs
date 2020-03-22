using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange2.Models
{
    public class BundleModel
    {
        public string Status { get; set; }
        public sale Sale { get; set; }
        public product Product { get; set; }


    }

    public class sale
    {
        public int Id { get; set; }
        public string Code { get; set; }
    }

    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
