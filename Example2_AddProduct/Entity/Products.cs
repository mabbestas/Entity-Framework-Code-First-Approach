using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_AddProduct.Entity
{
    public class Products : BaseEntity
    {
        [ForeignKey("Category")]  // Eğer isim shipvia örneğinde olduğu gibi farklı ise yapılması gerekiyor.
        public int CategoryID { get; set; }

        public decimal? UnitPrice { get; set; }
        public short? UnitInStock { get; set; }

        // Navigation

        public virtual Category Category { get; set; }

    }
}
