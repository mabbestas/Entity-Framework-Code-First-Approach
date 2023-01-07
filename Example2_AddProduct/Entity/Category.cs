using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_AddProduct.Entity
{
    public class Category : BaseEntity
    {     
        [MaxLength(255)]  // kolunun veri tipini değiştirmeden 255 karakter ile sınırladık.
        public string Description { get; set; }


        // Navigation Property
        // 1 kategoriden 1'den fazla ürün olabilir.
        public virtual List<Products> Products { get; set; }

    }
}
