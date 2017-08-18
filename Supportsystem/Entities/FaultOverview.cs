using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supportsystem
{

    public class FaultOverview
    {
        private IReaderWriter<MachineCatalogue> _rw = new MachineCatalogueXmlReaderWriter();

        private MachineCatalogue _machines;

        private List<Fault> _faults = new List<Fault>();

        public List<Fault> Faults { get => _faults; set => _faults = value; }

        public static readonly int ALL = 0;
        public static readonly int UNRESOLVED = 1;
        public static readonly int RESOLVED = 2;


        public FaultOverview()
        {

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
            foreach(KeyValuePair<string,Machine> entry in _machines.Machines)
            {
                _faults.AddRange(entry.Value.Faults);
            }
        }

        private void GetUnresolvedFaults()
        {
            GetAllFaults();

            foreach(Fault fault in _faults)
            {
                if (fault.Resolved)
                {
                    _faults.Remove(fault);
                }
            }

        }

        private void GetResolvedFaults()
        {
            GetAllFaults();

            foreach(Fault fault in _faults)
            {
                if (!fault.Resolved)
                {
                    _faults.Remove(fault);
                }
            }
        }



    }
}
