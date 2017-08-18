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
        private string _comnumber;
        private string _customer;
        private string _location;
        private List<Fault> _faults;

        public string Comnumber
        {
            get { return _comnumber; }
            set { _comnumber = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public string Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public List<Fault> Faults
        {
            get { return _faults; }
            set { _faults = value; }
        }

        public int NumberOfFaults
        {
            get { return Faults.Count(); }
        }

        public Machine() { }

        public Machine(string comnumber, string customer, string location)
        {
            Comnumber = comnumber;
            Location = location;
            Customer = customer;
            Faults = new List<Fault>();
        }

        public override string ToString()
        {
            return Comnumber + " " + Location + " " + Customer + " ";
        }

        public void AddFault(Fault fault)
        {
            if (Faults == null)
            {
                Faults = new List<Fault>
                {
                    fault
                };
            }
            else
            {
                Faults.Add(fault);
            }
        }

        public Fault FindFault(string id)
        {
            foreach(Fault fault in Faults)
            {
                if (fault.ID.ToString() == id)
                {
                    return fault;
                }
            }
            return null;
        }
    }
}
