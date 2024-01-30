using ConsoleApp1;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class DiamondGeneratorTests
    {
        private static DiamondGenerator? testedObject;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            testedObject = new DiamondGenerator();
        }

        [TestMethod]
        public void GenerateModel()
        {
            IList<IList<char>> result = testedObject.GenerateModel();
        }
    }
}