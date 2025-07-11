using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSale.Report
{
    internal interface IReportGenerator
    {
        void exportPdf(Chart chart1, Chart chartEmpSales, DataGridView dataGridViewRevenue);
    }
}
