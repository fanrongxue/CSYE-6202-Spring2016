using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{

    public class CommisonEmployee : Employee
    {
        private decimal grossSale { get; set; }
        private decimal commissionRate { get; set; }
        public CommisonEmployee(string first, string last, string ssn, decimal sale, decimal rate) : base(first, last, ssn)
        {
            grossSale = sale;
            commissionRate = rate;
        }

        public override decimal Earnings()
        {
            return grossSale * commissionRate;
        }

        public override string ToString()
        {
            return string.Format("{0} :{1}\n{2}:{3:c}\n{4}:{5:F2}", "commission employee", base.ToString(), "gross salary", grossSale,
                "commission rate", commissionRate);

        }




    }
}
