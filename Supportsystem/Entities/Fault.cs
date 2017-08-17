using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{
    [Serializable]
    public class Fault
    {
        private Boolean _resolved = false;
        private string _name;
        private string _description;
        private DateTime _date;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public bool Resolved
        {
            get { return _resolved; }
            set { _resolved = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Fault(String name, String description)
        {
            Name = name;
            Description = description;
        }

        public Fault() { }


    }
}
