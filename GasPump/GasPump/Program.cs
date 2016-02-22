using System;

namespace GasPump
{
    public class Program
    {
        public enum GasType
        {
            None,
            RegularGas,
            MidgradeGas,
            PremiumGas,
            DieselFuel
        }

        static void Main(string[] args)
        {
            Console.Write("please enter purchased gas type,Q/p to quit: ");
            string type = Console.ReadLine();
            if (UserEnteredSentinelValue(type))
            {
                Console.WriteLine("applicaion terminate");
            }

            while (UserEnteredValidGasType(type))
            {
                Console.WriteLine("please enter purchased gas amount,Q/p to quit: ");
                string gasAmount = Console.ReadLine();
                if (UserEnteredValidAmount(gasAmount))
                {
                    Console.WriteLine("gasamount:" + gasAmount);


                    GasType gastype = GasTypeMapper(Convert.ToChar(type));
                    double price = GasPriceMapper(gastype);
                    Console.WriteLine(price);
                    CalculateTotalCost(gastype, Convert.ToInt32(gasAmount), ref price);
                    Console.WriteLine(price);

                    Console.Write("please enter purchased gas type,Q/p to quit: ");
                    Console.WriteLine();
                    Console.ReadLine();
                }
            }

            // your implementation here
        }


        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
        {

            var result = false;
            if (userInput != null)
            {
                if (userInput.Equals("q") || userInput.Equals("Q"))
                {
                    result = true;
                     Console.WriteLine("applicaion terminate");
                }
            }
            else
            {
                result = false;
            }
            // your implementation here

            return result;

        }
        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        {
            var result = false;
            if (userInput != null)
            {
                if (userInput.Equals("r") || userInput.Equals("m") || userInput.Equals("p") || userInput.Equals("d")
                   || userInput.Equals("R") || userInput.Equals("M") || userInput.Equals("P") || userInput.Equals("D"
                    ))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            // your implementation here

            return result;
        }

        // use this method to parse and check the double type entered
        // please use Double.TryParse() method 
        public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;
            if (userInput != null && userInput != " ")
            {
                double amount;
                if (!Double.TryParse(userInput, out amount))

                    return false;

                else {
                    double.TryParse(userInput, out amount);
                    if (amount < 0)
                    {
                        return false;
                    }

                    return true;
                }
            }

            if (userInput == " ")
            {
                return false;
            }

            // your implementation here

            return result;
        }

        // use this method to map a valid char entry to its enum representation
        // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
        // this mapping "must" be used within CalculateTotalCost() method later on
        public static GasType GasTypeMapper(char c)
        {
            GasType gasType = GasType.None;
            if (c == 'R' || c == 'r')
            {
                gasType = GasType.RegularGas;
            }
            if (c == 'M' || c == 'm')
            {
                gasType = GasType.MidgradeGas;
            }
            if (c == 'P' || c == 'p')
            {
                gasType = GasType.PremiumGas;
            }
            else if (c == 'D' || c == 'd')
            {
                gasType = GasType.DieselFuel;
            }

            // your implementation here

            return gasType;
        }

        public static double GasPriceMapper(GasType gasType)
        {
            var result = 0.0;
            if (gasType.ToString() == "RegularGas") { return 1.94; }
            if (gasType.ToString() == "MidgradeGas") { return 2.0; }
            if (gasType.ToString() == "PremiumGas") { return 2.24; }
            if (gasType.ToString() == "DieselFuel") { return 2.17; }
            // your implementation here
            return result;
        }

        public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
        {
            totalCost = GasPriceMapper(gasType) * gasAmount;

            // your implementation here
        }
    }
}