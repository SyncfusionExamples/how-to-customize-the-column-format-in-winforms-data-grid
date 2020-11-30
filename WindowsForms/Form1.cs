using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percentage_Column
{
    public partial class Form1 : Form
    {
        SfDataGrid sfDataGrid1;
        OrderInfoCollection orderInfo;
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1 = new SfDataGrid();
            orderInfo = new OrderInfoCollection();
            sfDataGrid1.Dock = DockStyle.Fill;
            sfDataGrid1.AllowFiltering = true;
            this.Controls.Add(sfDataGrid1);
            NumberFormatInfo numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat = Application.CurrentCulture.NumberFormat.Clone() as NumberFormatInfo;
            numberFormat.PercentDecimalDigits = 4;
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Text" });
            this.sfDataGrid1.Columns.Add(new GridNumericColumn() { MappingName = "Value", FormatMode = FormatMode.Percent , NumberFormatInfo = numberFormat });
            this.sfDataGrid1.DataSource = orderInfo.Orders;
            sfDataGrid1.Columns["Value"].Format = "00,00%";
            sfDataGrid1.Columns["Value"].FormatProvider = new CustomFormatter();

        }
    }
    public class CustomFormatter : IDataGridFormatProvider
    {
        public object Format(string format, GridColumnBase gridColumn, object record, object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException((value == null) ? "format" : "args");
            }

            if (gridColumn is GridColumn && (gridColumn as GridColumn).MappingName == "Value")
            {
                var orderInfo = record as OrderInfo;
                 return (Convert.ToDecimal((orderInfo.Value.ToString()))).ToString("0.00%");
            }
            return value.ToString();
        }


        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
