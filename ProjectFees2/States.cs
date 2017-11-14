using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFees2
{
    public class States
    {
        public List<StateFees> ServiceAreaStates = new List<StateFees>();
        public decimal OutOfAreaFee { get; private set; }

        public States()
        {
            ServiceAreaStates.Add(new StateFees("Florida", "FL", 8.99m));
            ServiceAreaStates.Add(new StateFees("Alabama", "AL", 4.99m));
            ServiceAreaStates.Add(new StateFees("New York", "NY", 15.45m));

            OutOfAreaFee = 49.99m;

        }

        public decimal GetFeeForState(string twoLetterCode)
        {
            var state = ServiceAreaStates.FirstOrDefault(f => f.TwoLetterCode.Equals(twoLetterCode.ToUpper()));
            return state != null ? state.Fee : OutOfAreaFee;
        }
    }
}
