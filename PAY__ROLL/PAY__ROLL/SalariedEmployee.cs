using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklysalary { get; set; }

        public SalariedEmployee(string first, string last, string ssn, decimal salary) : base(first, last, ssn)
        {
            weeklysalary = salary;
        }



        public override decimal Earnings()
        {
            return weeklysalary;
        }
        public override string ToString()
        {
            return string.Format("slaried employee:{0}\n{1}:{2:C}", base.ToString(), "weekly salary", weeklysalary);

        }
    }
}
