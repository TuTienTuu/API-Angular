using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Models
{
    [Table("ProductTags")]
  public  class ProductTag
    {
        [Key]
        [Column(Order =1)]

        public int ProductID { get; set; }

        [Key]
        [Column(TypeName ="varchar",Order = 2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual IEnumerable<Product> Product { get; set; }

        [ForeignKey("TagID")]
        [MaxLength(50)]
        public virtual IEnumerable<Tag> Tag { get; set; }

    }
}
