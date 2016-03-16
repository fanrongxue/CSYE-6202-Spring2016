using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAY__ROLL
{
   public  class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee emp1 = new SalariedEmployee("john", " smith", "111-11-111", 800.00m);
            HourlyEmployee emp2 = new HourlyEmployee("karen", " price", "222-22-2222", 16.75m, 40.0m);
            CommisonEmployee emp3 = new CommisonEmployee("sue", " jones", "333-33-3333", 1000.00m, 0.6m);
            BasePlusCommission emp4 = new BasePlusCommission("jbob", " lewis", "444-44-4444", 5000.00m, .04m, 300.00m);

            Console.WriteLine("Employees processed individually:\n");
            Console.WriteLine("{0}\neared:{1:C}\n:", emp1, emp1.Earnings());
            Console.WriteLine("{0}\neared:{1:C}\n:", emp2, emp2.Earnings());
            Console.WriteLine("{0}\neared:{1:C}\n:", emp3, emp3.Earnings());
            Console.WriteLine("{0}\neared:{1:C}\n:", emp4, emp4.Earnings());


            Employee[] employees = new Employee[4];
            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;
            employees[3] = emp4;

        }
    }
}
