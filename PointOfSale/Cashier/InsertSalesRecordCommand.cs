using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal class InsertSalesRecordCommand : ICommandWithBillNo
    {

        private readonly CashierMain _form;

        public InsertSalesRecordCommand(CashierMain form)
        {
            _form = form;
        }

        public void Execute(int billNo)
        {
            _form.InsertSalesRecord(billNo);  // Call InsertSalesRecord with billNo
        }

        public void Execute() { }
    }
}
