using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal class UpdateQtyCommand : ICommand
    {
        private readonly CashierMain _form;

        public UpdateQtyCommand(CashierMain form)
        {
            _form = form;
        }

        public void Execute()
        {
            _form.updateQty();  // Call the updateQty method in CashierMain
        }

        public void Execute(int billNo) { }
    }
}
