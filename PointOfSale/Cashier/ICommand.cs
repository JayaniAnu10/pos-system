using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal interface ICommand
    {
        void Execute(); // For commands that don't need parameters
        void Execute(int billNo);
    }
}
