namespace Athene
{
    public class WeakestRowMatrixProblem
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            return mat
                .Select((m, i) => new { Index = i, Count = m.Count(el => el == 1) })
                .ToDictionary(kvp => kvp.Index, kvp => kvp.Count)
                .OrderBy(kvp => kvp.Value)
                .Take(k)
                .Select(kvp => kvp.Key)
                .ToArray();
        }
    }
}
