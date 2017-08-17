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
        private List<string> tickets;

        public string Comnumber
        {
            get { return comnumber; }
            set { comnumber = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public List<string> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public Machine() { }

        public Machine(string comnumber, string customer, string location)
        {
            Comnumber = comnumber;
            Location = location;
            Customer = customer;
            Tickets = null;
        }

        public override string ToString()
        {
            return Comnumber + " " + Location + " " + Customer + " ";
        }
    }
}
