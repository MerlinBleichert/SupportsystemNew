using Supportsystem.DataLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Supportsystem
{

    public class FaultOverview
    {
        private MachineCatalogue _machines;

        public FaultOverview(MachineCatalogue mc)
        {
            _machines = mc;
        }

        private IEnumerable<Fault> GetFaultsByPredicate(Func<Fault, bool> predicate)
        {
            return _machines.Machines.SelectMany(f => f.Value.Faults.Where(predicate));
        }

        public List<Fault> GetAllFaults()
        {
            return this.GetFaultsByPredicate(fault => true).ToList();
        }

        public List<Fault> GetUnresolvedFaults()
        {
            return this.GetFaultsByPredicate(fault => fault.Resolved == false).ToList();
        }

        public List<Fault> GetResolvedFaults()
        {
            return this.GetFaultsByPredicate(fault => fault.Resolved == true).ToList();
        }

        public Fault FindFault(int id)
        {
            return this.GetFaultsByPredicate(fault => fault.ID == id).FirstOrDefault();
        }



    }
}
