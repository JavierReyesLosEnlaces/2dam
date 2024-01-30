using ClassLibrary1;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Reflection;
using System.Security.AccessControl;

namespace Informe
{
    public partial class Form2 : Form
    {
        public List<SalesLine> ds = SalesLineDS.getSalesLine();
        public DataTable dt = new DataTable();


        public Form2()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Informe.Report1.rdlc";
            dt = toDataTable(ds);
            ReportDataSource source = new ReportDataSource("ReportDS1", dt);
            reportViewer1.LocalReport.DataSources.Add(source);
        }

        public DataTable toDataTable<T>(List<T>items)
        {
            DataTable datatable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);    
            foreach (PropertyInfo prop in Props)
            {
                // Creamos las columnas segun las propiedades tipo T, con el nombre de esta
                datatable.Columns.Add(prop.Name);
            }
            foreach(T item in items)
            {
                var values = new object[Props.Length];
                for(int i = 0; i< Props.Length; i++)
                {
                    //Insertamos los calores de icha propiedad en un array para crear la fila (row)
                    //values[i] = Props[i].GetValue(item, null);
                    values[i] = Props[i].GetValue(item, null);
                }
                datatable.Rows.Add(values);
            }
               
            return datatable;
        }
    }
}
