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
        readonly List<LineItem> _items;

        public Order(String name, String address, List<LineItem> items)
        {
            this._name = name;
            this._address = address;
            this._items = items;
        }

        public string GetCustomerName()
        {
            return _name;
        }

        public string GetCustomerAddress()
        {
            return _address;
        }

        public List<LineItem> GetLineItems()
        {
            return _items;
        }
    }
}
