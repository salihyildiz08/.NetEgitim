﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uzaktan.Core.Domain.Entities
{
    [Table(name:"categories")]
    public class Category:BaseEntity<int>
    {
        [Column(name:"category_name",TypeName ="varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(name:"is_active")]
        public bool? IsActive { get; set; }
        public ICollection<Product> Products { get; set; }

        public Category()
        {
            IsActive = true;
        }
    }
}
