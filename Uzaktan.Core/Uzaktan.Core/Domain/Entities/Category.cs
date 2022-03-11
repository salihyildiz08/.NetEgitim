using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Uzaktan.Core.Domain.Entities
{
   
    public class Category:BaseEntity<int>
    {
      
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
