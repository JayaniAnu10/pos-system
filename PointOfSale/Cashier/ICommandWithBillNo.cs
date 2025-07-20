using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal interface ICommandWithBillNo : ICommand
    {
        void Execute(int billNo);
    }
}
