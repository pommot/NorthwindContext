using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Northwind.Models;


namespace Northwind.Data
{
    public class DbInitializer
    {
        public static void Initialize(NorthwindContext context)
        {
            // Look for any Products.
            if (context.Produtos.Any())
            {
                return;
            }
            context.SaveChanges();
        }

    }
}
