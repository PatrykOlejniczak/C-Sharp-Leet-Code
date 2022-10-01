namespace Athene
{
    public class RansomNoteProblem
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var letters = magazine
                            .GroupBy(c => c)
                            .ToDictionary(c => c.Key, c => c.Count());

            foreach (var letter in ransomNote)
            {
                if (letters.TryGetValue(letter, out int cLetter))
                {
                    if (cLetter == 0)
                        return false;

                    letters[letter] -= 1;   
                }
                else
                    return false;
            }

            return true;
        }
    }
}
