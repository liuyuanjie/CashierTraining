using System;
using System.Collections.Generic;
using CashierTraining;
using Xunit;

namespace CashierTrainingTests
{
    public class CashierTest
    {
        [Fact]
        void should_print_customer_information_on_order()
        {
            Order order = new Order("Mr X", "Chicago, 60601", new List<LineItem>());
            OrderReceipt receipt = new OrderReceipt(order);

            String output = receipt.GetPrintReceipt();


            Assert.Contains("Mr X", output);
            Assert.Contains("Chicago, 60601", output);
        }

        void should_print_line_item_and_sales_tax_information()
        {
            List<LineItem> lineItems = new List<LineItem>()
            {
                new LineItem("milk", 10.0, 2),
                new LineItem("biscuits", 5.0, 5),
                new LineItem("chocolate", 20.0, 1)
            };
            OrderReceipt receipt = new OrderReceipt(new Order(null, null, lineItems));

            string output = receipt.GetPrintReceipt();

            Assert.Contains("milk\t10.0\t2\t20.0\n", output);
            Assert.Contains("biscuits\t5.0\t5\t25.0\n", output);
            Assert.Contains("chocolate\t20.0\t1\t20.0\n", output);
            Assert.Contains("Sales Tax\t6.5", output);
            Assert.Contains("Total Amount\t71.5", output);
        }
    }
}