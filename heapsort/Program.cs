using System.Text;

public static class Program
{
    private static void Main(string[] args)
    {
        int[] a = new[] { 6, 3, 7, 9, 12, 17, 1, 14, 20 };
        int level = 1, remaining = a.Length, currentIndex = 0;

        Dictionary<int, int[]> levels = new();
        while (remaining > 0)
        {
            int maxLevelItems = (int)Math.Pow(2, level - 1);
            int levelItems = Math.Min(maxLevelItems, remaining);

            levels.Add(level,a.Skip(currentIndex).Take(levelItems).ToArray());
            Console.WriteLine(string.Join(" ",levels[level]));
            
            currentIndex += levelItems;
            remaining -= levelItems;
            level++;
           
        }
    }
}