using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTraining
{
    public class OrderReceipt
    {
        private Order o;

        public OrderReceipt(Order o)
        {
            this.o = o;
        }

        public String printReceipt()
        {
            StringBuilder output = new StringBuilder();

            // print headers
            output.Append("======Printing Orders======\n");

            // print date, bill no, customer name
            //        output.append("Date - " + order.getDate();
            output.Append(o.getCustomerName());
            output.Append(o.getCustomerAddress());
            //        output.append(order.getCustomerLoyaltyNumber());

            // prints lineItems
            double totSalesTx = 0d;
            double tot = 0d;
            foreach (LineItem lineItem in o.getLineItems())
            {
                output.Append(lineItem.getDescription());
                output.Append('\t');
                output.Append(lineItem.getPrice());
                output.Append('\t');
                output.Append(lineItem.getQuantity());
                output.Append('\t');
                output.Append(lineItem.totalAmount());
                output.Append('\n');

                // calculate sales tax @ rate of 10%
                double salesTax = lineItem.totalAmount() * .10;
                totSalesTx += salesTax;

                // calculate total amount of lineItem = price * quantity + 10 % sales tax
                tot += lineItem.totalAmount() + salesTax;
            }

            // prints the state tax
            output.Append("Sales Tax").Append('\t').Append(totSalesTx);

            // print total amount
            output.Append("Total Amount").Append('\t').Append(tot);
            return output.ToString();
        }
    }
}
