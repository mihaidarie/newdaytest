namespace ConsoleApp1
{
    public class DiamondGenerator
    {
        public IList<IList<char>> GenerateModel(char input)
        {
            if (input == default)
            {
                return new List<IList<char>> { new List<char> { } };
            }

            if (input == 'A')
            {
                return new List<IList<char>> { new List<char> { 'A' } };
            }

            return new List<IList<char>>();
        }
    }
}
