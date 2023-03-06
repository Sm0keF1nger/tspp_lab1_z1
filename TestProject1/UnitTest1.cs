using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            int result = lab1_z1.Program.Equation(x);
            Assert.AreEqual(10, result);
        }

    }
}