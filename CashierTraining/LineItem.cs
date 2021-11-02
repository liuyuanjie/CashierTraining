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

        public LineItem(String description, double price, int quantity)
        {
            this._description = description;
            this._price = price;
            this._quantity = quantity;
        }

        public String GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public double GeTotalAmount()
        {
            return _price * _quantity;
        }
	}
}
