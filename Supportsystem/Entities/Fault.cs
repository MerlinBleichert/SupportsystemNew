using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem.Entities
{
    public class Fault
    {
        private Boolean _resolved = false;
        private string _name;
        private string _description;

        public Fault(String name, String description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Resolved { get => _resolved; set => _resolved = value; }


    }


}
