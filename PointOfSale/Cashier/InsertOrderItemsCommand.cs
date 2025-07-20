using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal class InsertOrderItemsCommand : ICommandWithBillNo
    {
        private readonly CashierMain _form;

        public InsertOrderItemsCommand(CashierMain form)
        {
            _form = form;
        }

        public void Execute(int billNo)
        {
            _form.InsertOrderItems(billNo);  // Call InsertOrderItems with billNo
        }

        public void Execute() { }
    }
}
