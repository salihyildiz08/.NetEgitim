using System;

namespace Uzaktan.Core.Domain.Entities
{
    public class Product:BaseEntity<int>
    {
        // public int Id { get; set; }
        public string ProductName { get; set; }
        public int UnitStock { get; set; }
        public int CatId { get; set; }
        public bool? IsActive { get; set; }
        public Category Category { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
