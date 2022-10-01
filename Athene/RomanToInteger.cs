namespace Athene
{
    public class RomanToInteger
    {
        public static readonly IDictionary<char, int> RomanEncodingMap
            = new Dictionary<char, int>()
        {
                    { 'I', 1 },
                    { 'V', 5 },
                    { 'X', 10 },
                    { 'L', 50 },
                    { 'C', 100 },
                    { 'D', 500 },
                    { 'M', 1000 }
        };

        public int RomanToInt(string accounts)
        {
            var result = 0;
            char? current = null;
            char? previous = null;
            var index = accounts.Length - 1;
            do
            {
                current = TakeIndexOrNull(index, accounts);
                previous = TakeIndexOrNull(index - 1, accounts);

                result += ConvertSingleNo(previous, current, out bool usedBoth);

                index = usedBoth ? index - 2 : index - 1;

            } while (current != null && previous != null);

            return result;
        }

        private char? TakeIndexOrNull(int index, string accounts)
        {
            return index < 0 ? null : index >= accounts.Length ? null : accounts[index];
        }

        private int ConvertSingleNo(char? second, char? first, out bool usedBoth)
        {
            usedBoth = false;
            if (first == null && second == null)
                return 0;

            if (first != null && second == null)
                return RomanEncodingMap[first.Value];

            if (RomanEncodingMap[first.Value] <= RomanEncodingMap[second.Value])
                return RomanEncodingMap[first.Value];

            usedBoth = true;
            return RomanEncodingMap[first.Value] - RomanEncodingMap[second.Value];
        }
    }
}
