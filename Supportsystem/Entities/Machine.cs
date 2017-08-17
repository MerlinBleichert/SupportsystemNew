using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    [Serializable]
    public class Machine
    {
        private string comnumber;
        private string customer;
        private string location;
        private List<Fault> faults;

        public Machine() { }

        public Machine(string comnumber,string customer, string location)
        {
            Comnumber = comnumber;
            Location = location;
            Customer = customer;
            Faults = null;
        }


        public string Comnumber { get => comnumber; set => comnumber = value; }
        public string Location { get => location; set => location = value; }
        public string Customer { get => customer; set => customer = value; }
        public List<Fault> Faults { get => faults; set => faults = value; }

        public override string ToString()
        {
            return Comnumber + " " + Location + " " + Customer + " " ;
        }

        public void AddFault(Fault fault)
        {
            if(Faults == null)
            {
                Faults = new List<Fault>();
                Faults.Add(fault);
            }
            else
            {
                Faults.Add(fault);
            }
        }
    }
}
