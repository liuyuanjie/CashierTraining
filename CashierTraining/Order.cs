using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTraining
{
    public class Order
    {
        String nm;
        String addr;
        List<LineItem> li;

        public Order(String nm, String addr, List<LineItem> li)
        {
            this.nm = nm;
            this.addr = addr;
            this.li = li;
        }

        public String getCustomerName()
        {
            return nm;
        }

        public String getCustomerAddress()
        {
            return addr;
        }

        public List<LineItem> getLineItems()
        {
            return li;
        }
    }
}
