using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_AddProduct.Entity
{
    [Table("Users")]  // veritabanında tablonun ismini 'users' olarak değiştirdik.
    public class AppUser : BaseEntity
    {
        [Required] // Bu kolona ver girişi zorunlu oldu.
        [MaxLength(30)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        public string  Password { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [NotMapped]  // bu propertyi tabloda bir kolon eklememek için kullandık. böylece sadece uygulamada kullanırız.
        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        public bool Gender { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? BirthDate { get; set; }
    }
}
