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
                            new List<char> { ' ', 'A', ' ' },
                            new List<char> { 'B', ' ', 'B' },
                            new List<char> { ' ', 'A', ' ' }
                        }
                    },
                    new object[] { 'C',
                        new List<List<char>>
                        {
                            new List<char> { ' ', ' ', 'A', ' ', ' ' },
                            new List<char> { ' ', 'B', ' ', 'B', ' ' },
                            new List<char> { 'C', ' ', ' ', ' ', 'C' },
                            new List<char> { ' ', 'B', ' ', 'B', ' ' },
                            new List<char> { ' ', ' ', 'A', ' ', ' ' }
                        }
                    },
                    new object[] { 'D',
                        new List<List<char>>
                        {
                            new List<char> { ' ', ' ', ' ', 'A', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', 'B', ' ', 'B', ' ', ' ' },
                            new List<char> { ' ', 'C', ' ', ' ', ' ', 'C', ' ' },
                            new List<char> { 'D', ' ', ' ', ' ', ' ', ' ', 'D' },
                            new List<char> { ' ', 'C', ' ', ' ', ' ', 'C', ' ' },
                            new List<char> { ' ', ' ', 'B', ' ', 'B', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', 'A', ' ', ' ', ' ' }
                        }
                    }
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