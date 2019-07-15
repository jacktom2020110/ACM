using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "IPhone";
                product.Description = "Thi is a phone";
                product.CurrentPrice = 3900M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            return true;
        }


    }
}
