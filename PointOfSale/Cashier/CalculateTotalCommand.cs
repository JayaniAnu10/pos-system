using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Cashier
{
    internal class CalculateTotalCommand : ICommand
    {
        private DataGridView DGV_List2;
        private TextBox txt_total;
        private TextBox txt_net;

        public CalculateTotalCommand(DataGridView dgv, TextBox totalBox, TextBox netBox)
        {
            DGV_List2 = dgv;
            txt_total = totalBox;
            txt_net = netBox;
        }

        public void Execute()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in DGV_List2.Rows)
            {
                if (!row.IsNewRow && row.Cells["Amount"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Amount"].Value.ToString(), out decimal amount))
                    {
                        totalAmount += amount;
                    }
                }
            }
            txt_total.Text = totalAmount.ToString("0.00");
            txt_net.Text = totalAmount.ToString("0.00");
        }

        public void Execute(int billNo) { }
    }
}
