using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Cashier
{
    internal class CommandInvoker
    {
        private List<ICommand> _commands = new List<ICommand>();

        // Add a command to the list
        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        // Execute all the commands, passing billNo when necessary
        public void ExecuteCommands(int billNo)
        {
            foreach (var command in _commands)
            {
                // Check if the command requires billNo
                if (command is ICommandWithBillNo commandWithBillNo)
                {
                    commandWithBillNo.Execute(billNo); // Execute with billNo
                }
                else
                {
                    command.Execute(); // Execute without billNo
                }
            }
        }
    }
}
