using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Store.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StoreID { get; set; }

        // Navigation Property

        public Store Store { get; set; }

    }
}
