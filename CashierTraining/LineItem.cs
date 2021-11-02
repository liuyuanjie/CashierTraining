using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTraining
{
    public class LineItem
    {
        private readonly string _description;
        private readonly double _price;
        private readonly int _quantity;

        public LineItem(string description, double price, int quantity)
        {
            _description = description;
            _price = price;
            _quantity = quantity;
        }

        private double GetTotalAmount()
        {
            return _price * _quantity;
        }

        public double GetTax()
        {
            return GetTotalAmount() * 0.1;
        }

        public double GetTotalAmountAndTax()
        {
            return GetTotalAmount() + GetTax();
        }

        public string GetPrintItemContent()
        {
            StringBuilder content = new StringBuilder();
            content.Append(_description);
            content.Append('\t');
            content.Append(_price.ToString("F1"));
            content.Append('\t');
            content.Append(_quantity);
            content.Append('\t');
            content.Append(GetTotalAmount().ToString("F1"));
            content.Append('\n');

            return content.ToString();
        }
    }
}