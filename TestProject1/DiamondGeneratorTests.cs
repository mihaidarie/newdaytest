using ConsoleApp1;
using FluentAssertions;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class DiamondGeneratorTests
    {
        private static DiamondGenerator? testedObject;

        private static IEnumerable<object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[] { 'A', new List<List<char>> { new List<char> { 'A' } } }
                };
            }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            testedObject = new DiamondGenerator();
        }

        [TestMethod]
        [DynamicData(nameof(TestData))]
        public void GenerateModel(char input, List<List<char>> expected)
        {
            IList<IList<char>> result = testedObject.GenerateModel();

            result.Should().BeEquivalentTo(expected);
        }
    }
}