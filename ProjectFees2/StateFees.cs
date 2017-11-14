using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFees2
{
    public class StateFees
    {
        public string Name { get; set; }
        public string TwoLetterCode { get; set; }
        public decimal Fee { get; set; }

        public StateFees(string name, string twoLetterCode, decimal fee)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            Fee = fee; 
        }
    }
}
