using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_Column
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }
        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo("t1" ,0.5678));
            _orders.Add(new OrderInfo("t2" ,0.6671));
            _orders.Add(new OrderInfo("t3" ,0.3675));
            _orders.Add(new OrderInfo("t4" ,0.3709));           
        }
    }
}
