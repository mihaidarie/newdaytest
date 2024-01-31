using ConsoleApp1;
using FluentAssertions;

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
                    },
                    new object[] { 'Z',
                        new List<List<char>>
                        {
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'A', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'B', ' ', 'B', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'C', ' ', ' ', ' ', 'C', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'D', ' ', ' ', ' ', ' ', ' ', 'D', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'E', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'F', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'G', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'G', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'H', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'H', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', ' ', 'I', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'I', ' ', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', ' ', 'J', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'J', ' ', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', ' ', 'K', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'K', ' ', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', ' ', 'L', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'L', ' ', ' ', ' ' },
                            new List<char> { ' ', ' ', 'M', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'M', ' ', ' ' },
                            new List<char> { ' ', 'N', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'N', ' ' },
                            new List<char> { 'O', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'O' },

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