using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{
    public abstract class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string socialSecurityNumber { get; private set; }

        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            socialSecurityNumber = ssn;
        }
        public abstract decimal Earnings();


        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number:{2}", FirstName, LastName, socialSecurityNumber);

        }
    }
}

