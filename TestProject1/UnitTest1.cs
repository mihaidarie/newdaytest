using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static DiamondPrinter testedObject;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            testedObject = new DiamondPrinter();
        }

        [TestMethod]
        public void TestMethod1()
        {
            testedObject.GeneratePrintableArray();
        }
    }
}