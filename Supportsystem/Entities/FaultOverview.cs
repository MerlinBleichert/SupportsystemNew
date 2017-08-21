using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Supportsystem
{

    public class FaultOverview
    {
        private IReaderWriter<MachineCatalogue> _rw = new MachineCatalogueXmlReaderWriter();

        private MachineCatalogue _machines;

        private List<Fault> _faults;

        public List<Fault> Faults { get => _faults; set => _faults = value; }

        public static readonly int ALL = 0;
        public static readonly int UNRESOLVED = 1;
        public static readonly int RESOLVED = 2;


        public FaultOverview()
        {
            _machines = _rw.Read("data");
        }

        public void ChangeList(int kind)
        {
            switch (kind)
            {
                case 0:
                    GetAllFaults();
                    break;
                case 1:
                    GetUnresolvedFaults();
                    break;
                case 2:
                    GetResolvedFaults();
                    break;
                default:
                    break;

            }
        }

        private void GetAllFaults()
        {
            _faults = new List<Fault>();

            foreach(KeyValuePair<string,Machine> entry in _machines.Machines)
            {
                _faults.AddRange(entry.Value.Faults);
            }
        }

        private void GetUnresolvedFaults()
        {
            GetAllFaults();

            for (int i = _faults.Count() - 1; i >= 0 ; i--)
            {
                if(_faults.ElementAt(i).Resolved)
                {
                    _faults.RemoveAt(i);
                }
            }

        }

        private void GetResolvedFaults()
        {
            GetAllFaults();

            for (int i = _faults.Count() - 1; i >= 0; i--)
            {
                if (!_faults.ElementAt(i).Resolved)
                {
                    _faults.RemoveAt(i);
                }
            }
        }

        public Fault FindFault(string id)
        {
            foreach (Fault fault in Faults)
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
