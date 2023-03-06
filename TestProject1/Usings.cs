using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class Usings
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int result = lab1_z1.Program.Equation(x);
            Assert.AreEqual(10, result);
        }

    }
}