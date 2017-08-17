using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{

    [Serializable]
    public class MachineCatalogue
    {
        private List<Machine> _machines = new List<Machine>();

        public List<Machine> Machines
        {
            get { return _machines; }
        }

        public MachineCatalogue() { }

        public void AddMachine(Machine machine)
        {
            if (_machines == null)
                _machines = new List<Machine>();
            _machines.Add(machine);
        }
    }
}
