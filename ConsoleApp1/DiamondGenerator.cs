using System.Collections;

namespace ConsoleApp1
{
    public class DiamondGenerator
    {
        private readonly HashSet<char> alphabet = new HashSet<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z'
        };

        public IList<IList<char>> GenerateModel(char input)
        {
            if (input == default)
            {
                return new List<IList<char>> { new List<char> { } };
            }

            if (input == alphabet.ElementAt(0))
            {
                return new List<IList<char>> { new List<char> { 'A' } };
            }



            return new List<IList<char>>();
        }
    }
}
