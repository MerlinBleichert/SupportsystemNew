using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class MachineCatalogue
    {

        public MachineCatalogue() { }

        private List<Machine> machines;

        public List<Machine> Machines { get => machines; set => machines = value; }

        public Boolean AddMachine(Machine machine)
        {
            if(Machines == null)
            {
                Machines = new List<Machine>();
                Machines.Add(machine);
                return true;
            }
            else
            {
                Machines.Add(machine);
                return true;
            }
        }
    }
}
