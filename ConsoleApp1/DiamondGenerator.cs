namespace ConsoleApp1
{
    public class DiamondGenerator
    {
        private readonly char[] alphabet = new char[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z'
        };

        /*
        _ _ A _ _
        _ B _ B _
        C _ _ _ C
        _ B _ B _
        _ _ A _ _

        _ _ _ A _ _ _
        _ _ B _ B _ _
        _ C _ _ _ C _
        D _ _ _ _ _ D
        _ C _ _ _ C _
        _ _ B _ B _ _
        _ _ _ A _ _ _

        */

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

            var output = new List<IList<char>> { };
            var totalLinesToGenerateWithoutMiddle = Array.IndexOf(alphabet, input);

            var maxEmptySpacesInTheMiddle = AddTopHalf(totalLinesToGenerateWithoutMiddle, output);

            AddMiddle(totalLinesToGenerateWithoutMiddle, maxEmptySpacesInTheMiddle, output);

            AddLowerHalf( output);

            return output;
        }

        private void AddMiddle(int totalLinesToGenerateWithoutMiddle, int maxEmptySpacesInTheMiddle, List<IList<char>> output)
        {
            var currentLevel = new List<char>
            {
                alphabet[totalLinesToGenerateWithoutMiddle]
            };

            AddSpaces(totalLinesToGenerateWithoutMiddle == 1 ? 1 : maxEmptySpacesInTheMiddle, currentLevel);

            currentLevel.Add(alphabet[totalLinesToGenerateWithoutMiddle]);

            output.Add(currentLevel);
        }

        private int AddTopHalf(int totalLinesToGenerateWithoutMiddle, List<IList<char>> output)
        {
            var maxEmptySpacesAround = totalLinesToGenerateWithoutMiddle;
            var maxEmptySpacesInTheMiddle = 0;

            for (int i = 0; i < totalLinesToGenerateWithoutMiddle; i++)
            {
                var currentLevel = new List<char>();

                AddSpaces(maxEmptySpacesAround, currentLevel);

                currentLevel.Add(alphabet[i]);

                if (i != 0)
                {
                    AddSpaces(maxEmptySpacesInTheMiddle, currentLevel);

                    currentLevel.Add(alphabet[i]);
                }

                AddSpaces(maxEmptySpacesAround, currentLevel);

                maxEmptySpacesAround--;

                maxEmptySpacesInTheMiddle += i == 0 ? 1 : 2;

                output.Add(currentLevel);
            }

            return maxEmptySpacesInTheMiddle;
        }

        private static void AddLowerHalf(IList<IList<char>> output)
        {
            var topHalf = output.Take(output.Count - 1);

            for(int i = topHalf.Count() - 1; i >= 0; i--)
            {
                output.Add(topHalf.ElementAt(i));
            }
        }

        private static void AddSpaces(int maxEmptySpacesAround, List<char> currentLevel)
        {
            for (int j = 0; j < maxEmptySpacesAround; j++)
            {
                currentLevel.Add(' ');
            }
        }
    }
}