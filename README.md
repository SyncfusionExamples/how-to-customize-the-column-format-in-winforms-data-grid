# How to customize the column format in WinForms DataGrid (SfDataGrid)?

How to customize the column format in WinForms DataGrid (SfDataGrid)?

# About the sample

SfDataGrid allows you to create and assign custom format for the columns through the IDataGridFormatProvider interface. The GridColumnBase.FormatProvider property can be used to set custom format for the columns.

```c#
sfDataGrid1.Columns["Value"].Format = "00,00%";
sfDataGrid1.Columns["Value"].FormatProvider = new CustomFormatter();
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
```
## Requirements to run the demo
 Visual Studio 2015 and above versions
