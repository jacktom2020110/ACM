using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// get order by ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {

            Order order = new Order(orderId);

            if (orderId == 10)
            {
                // hard-code
                order.OrderDate = DateTime.Now;
            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
