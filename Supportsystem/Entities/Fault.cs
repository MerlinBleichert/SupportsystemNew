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
        private int _id;
        private string _description;
        private DateTime _date;



        public int ID
        {
            get { return _id; }
            set { _id = value; }
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

        

        public Fault(string description)
        {
            Description = description;
            Date = DateTime.Now;
            // Die Zuweisung ist nur Übergangsweise, keine Sorge :P
            ID = new Random().Next(9999999);

        }

        public Fault() { }


    }
}
