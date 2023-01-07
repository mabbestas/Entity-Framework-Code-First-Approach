using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_AddProduct.Entity
{
    public class BaseEntity
    {
        [Key] // Bu kolonu PK olarak ayarla. Identity sini 1'den başlayıp 1'er arttır.
        [Column(Order = 1)]
        public int ID { get; set; }

        [Required]
        [Column(Order = 2)]
        public string Name { get; set; }
        public bool IsActive { get; set; }

        // ? işareti eli kolon nullable olarak ayarlanır.
        [Column(TypeName = "datetime2")]     // kolonun veri tipini datetime2 olarak değiştirdik.
        public DateTime? AddedDate { get; set; }
    }
}
