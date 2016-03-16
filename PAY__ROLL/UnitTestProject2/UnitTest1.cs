using NUnit.Framework;


namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTest1
    {
     
        [TestFixtureSetUp]
        public void SalariedEmployee()
        {
            // prepare
            double eeklysalary;

            // action
            Program.CalculateTotalCost(Program.GasType.RegularGas, amount, ref totalCost);

            // assert
            Assert.That(expected, Is.EqualTo((int)totalCost));
        }
        [TestFixtureSetUp]
        public void BasePlusCommission()
        {
            // prepare
            double eeklysalary;

            // action
            Program.CalculateTotalCost(Program.GasType.RegularGas, amount, ref totalCost);

            // assert
            Assert.That(expected, Is.EqualTo((int)totalCost));
        }
    }
}
