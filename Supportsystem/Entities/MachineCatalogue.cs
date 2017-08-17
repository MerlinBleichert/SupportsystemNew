using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Supportsystem
{

    [Serializable]
    public class MachineCatalogue
    {

        private Dictionary<String,Machine> _machines = new Dictionary<string, Machine>();

        public Dictionary<String,Machine> Machines
        {
            get { return _machines; }
        }

        public MachineCatalogue() { }

        public void AddMachine(Machine machine)
        {
            _machines.Add(machine.Comnumber,machine);
        }
    }
}
