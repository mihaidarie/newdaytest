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
                    new object[] { null, new List<List<char>> { new List<char> { } } },
                    new object[] { 'A', new List<List<char>> { new List<char> { 'A' } } },
                    new object[] { 'B',
                        new List<List<char>> 
                        {
                            new List<char> { '_', 'A', '_' },
                            new List<char> { 'B', '_', 'B' },
                            new List<char> { '_', 'A', '_' }
                        }
                    },
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
            IList<IList<char>> result = testedObject.GenerateModel(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}