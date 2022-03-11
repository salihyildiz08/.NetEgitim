using Microsoft.EntityFrameworkCore;

namespace Uzaktan.Data
{
    public class ShoppingContext:DbContext
    {
        public ShoppingContext(DbContextOptions options):base(options)
        {

        }
    }
}
