using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class DiamondGeneratorTests
    {
        private static DiamondGenerator testedObject;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            testedObject = new DiamondGenerator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            testedObject.GeneratePrintableArray();
        }
    }
}