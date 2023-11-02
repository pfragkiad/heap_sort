int[] a = new[] { 6, 3, 7, 9, 12, 17, 1, 14, 20 };
int level = 1, remaining = a.Length, currentIndex = 0;

List<string> levels = new();
while (remaining > 0)
{
    int maxLevelItems = (int)Math.Pow(2, level - 1);
    int levelItems = Math.Min(maxLevelItems, remaining);
    for (int i = currentIndex; i < currentIndex + levelItems; i++)
        Console.Write($"{a[i]} ");
    currentIndex += levelItems;
    remaining -= levelItems;
    Console.WriteLine();
    level++;
}