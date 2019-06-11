using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Model.Models
{
    [Table("VisitorStatistics")]
   public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime VisitDate { get; set; }
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}
