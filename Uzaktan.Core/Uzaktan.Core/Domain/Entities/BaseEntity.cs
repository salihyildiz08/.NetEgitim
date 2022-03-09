namespace Uzaktan.Core.Domain.Entities
{
    public class BaseEntity<T> where T:struct //struct -> int,byte ve char bunlar struct'tır.
    {
        public T Id { get; set; }
    }
}
