namespace Uzaktan.Core.Domain.Entities
{
    public class Product:BaseEntity<int>
    {
        // public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public Category Category { get; set; }
    }
}
