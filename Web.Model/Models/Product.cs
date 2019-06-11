﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Web.Model.Abstract;

namespace Web.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Alias { get; set; }

        public int CategoryID { get; set; }

        public string Image { get; set; }

        public XElement MoreImages { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }

        public int Description { get; set; }

        public string Content { get; set; }
        public bool? HomeFlag { get; set; }

        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategories { get; set; }

    }
}
