using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    public class Machine
    {
        private string comnumber;
        private string customer;
        private string location;
        private List<string> tickets;


        public Machine(string comnumber,string customer, string location)
        {
            Comnumber = comnumber;
            Location = location;
            Customer = customer;
            Tickets = null;
        }


        public string Comnumber { get => comnumber; set => comnumber = value; }
        public string Location { get => location; set => location = value; }
        public string Customer { get => customer; set => customer = value; }
        public List<string> Tickets { get => tickets; set => tickets = value; }

        public override string ToString()
        {
            return Comnumber + " " + Location + " " + Customer + " " ;
        }
    }
}
