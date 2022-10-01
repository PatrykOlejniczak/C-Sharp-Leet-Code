namespace Athene
{
    public class FizzBuzzProblem
    {
        public IList<string> FizzBuzz(int n)
        {
            return FizzBuzzer(n).ToList();
        }

        private IEnumerable<string> FizzBuzzer(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string? result = null;
                if (i % 3 == 0)
                    result += "Fizz";

                if (i % 5 == 0)
                    result += "Buzz";

                yield return result ?? i.ToString();
            }
        }
    }
}