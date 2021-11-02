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
            this._order = order;
        }

        public string GetPrintReceipt()
        {
            StringBuilder output = new StringBuilder();

            // print headers
            output.Append("======Printing Orders======\n");

            output.Append(_order.GetCustomerName());
            output.Append(_order.GetCustomerAddress());

            // prints lineItems
            double totalTax = 0d;
            double totalAmount = 0d;
            foreach (LineItem lineItem in _order.GetLineItems())
            {
                output.Append(lineItem.GetDescription());
                output.Append('\t');
                output.Append(lineItem.GetPrice());
                output.Append('\t');
                output.Append(lineItem.GetQuantity());
                output.Append('\t');
                output.Append(lineItem.GeTotalAmount());
                output.Append('\n');

                // calculate sales tax @ rate of 10%
                double salesTax = lineItem.GeTotalAmount() * .10;
                totalTax += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                totalAmount += lineItem.GeTotalAmount() + salesTax;
            }

            // prints the state tax
            output.Append("Sales Tax").Append('\t').Append(totalTax);

            // print total amount
            output.Append("Total Amount").Append('\t').Append(totalAmount);
            return output.ToString();
        }
    }
}
