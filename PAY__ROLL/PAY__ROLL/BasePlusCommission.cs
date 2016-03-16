using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{
    public class BasePlusCommission : CommisonEmployee
    {
        private decimal baseSalary;
        public BasePlusCommission(string first, string last, string ssn, decimal sale, decimal rate, decimal salary) : base(first, last, ssn, sale, rate)
        {
            Basesalry = salary;
        }

        public decimal Basesalry
        {
            get
            {
                return baseSalary;
            }
            set
            {
                baseSalary = (value >= 0) ? value : 0;

            }
        }


        public override decimal Earnings()
        {
            return baseSalary + base.Earnings();

        }
        public override string ToString()
        {
            return string.Format("based-slaary {0}; base salary:{1:C}", base.ToString(), Basesalry);

        }
    }
}
