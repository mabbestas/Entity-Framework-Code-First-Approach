using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Store.Entity
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public IEnumerable<Product> Products { get; set; }
    }
}
