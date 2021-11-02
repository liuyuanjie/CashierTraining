using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTraining
{
    public class Order
    {
        private readonly string _name;
        private readonly string _address;
        private readonly List<LineItem> _items;

        public Order(string name, string address, List<LineItem> items)
        {
            _name = name;
            _address = address;
            _items = items;
        }

        private StringBuilder GetOrderCustomContent()
        {
            StringBuilder content = new StringBuilder();
            content.Append(_name);
            content.Append(_address);

            return content;
        }

        private double GetOrderTax()
        {
            double tax = 0;
            foreach (var item in _items)
            {
                tax += item.GetTax();
            }

            return tax;
        }

        private StringBuilder GetOrderTaxContent()
        {
            StringBuilder content = new StringBuilder();
            return content.Append("Sales Tax").Append('\t').Append(GetOrderTax().ToString("F1"));
        }

        private double GetOrderAmountAndTax()
        {
            double amountAndTax = 0;
            foreach (var item in _items)
            {
                amountAndTax += item.GetTotalAmountAndTax();
            }

            return amountAndTax;
        }

        private StringBuilder GetOrderAmountAndTaxContent()
        {
            StringBuilder content = new StringBuilder();
            return content.Append("Total Amount").Append('\t').Append(GetOrderAmountAndTax().ToString("F1"));
        }

        public string GetOrderContent()
        {
            StringBuilder content = new StringBuilder();

            content.Append(GetOrderCustomContent());
            content.Append(GetOrderItemsContent());
            content.Append(GetOrderTaxContent());
            content.Append(GetOrderAmountAndTaxContent());

            return content.ToString();
        }

        private StringBuilder GetOrderItemsContent()
        {
            StringBuilder content = new StringBuilder();

            foreach (var item in _items)
            {
                content.Append(item.GetPrintItemContent());
            }

            return content;
        }
    }
}