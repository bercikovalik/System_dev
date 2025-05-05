using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alviro
{
    public class ProductIngredientDTO
    {
        
            public string ProductName { get; set; }
            public int ProductId { get; set; }
            public string RewriteUrl { get; set; }
            public Guid ProductBvin { get; set; }
            public List<Guid> CategoryIds { get; set; }
            //public string CategoryName { get; set; }

        
    }
}
