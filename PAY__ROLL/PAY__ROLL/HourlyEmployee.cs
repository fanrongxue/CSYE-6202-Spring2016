using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;
        private decimal hours;

        public HourlyEmployee(string first, string last, string ssn, decimal HourlyWage, decimal hoursworked) : base(first, last, ssn)
        {
            wage = HourlyWage;
            hours = hoursworked;
        }

        public override decimal Earnings()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
                return (40 * wage) + ((hours - 40) * wage * 1.5M);
        }
        public override string ToString()
        {
            return string.Format("hourly employee:{0}\n{1}:{2:C};{3}:{4:F2}", base.ToString(), "hourly wage", wage, "houly hour", hours);

        }
    }
}
