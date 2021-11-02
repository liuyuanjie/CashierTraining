using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTraining
{
    public class OrderReceipt
    {
        private readonly Order _order;

        public OrderReceipt(Order order)
        {
            _order = order;
        }

        public string GetPrintReceipt()
        {
            var output = new StringBuilder();
            
            output.Append(GetOrderTitleContent());
            output.Append(_order.GetOrderContent());

            return output.ToString();
        }

        private static string GetOrderTitleContent()
        {
            return "======Printing Orders======\n";
        }
    }
}