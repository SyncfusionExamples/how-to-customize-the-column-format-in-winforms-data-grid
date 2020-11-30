using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_Column
{
    public class OrderInfo
    {
        string text;
        double values;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public double Value
        {
            get { return values; }
            set { values = value; }
        }
        public OrderInfo(string text,double values)
        {
            this.Text = text;
            this.Value = values;
        }
    }
}
