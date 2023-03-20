public class TrappingRainWater
{
    public void Execute()
    {
        Console.Clear();
        Console.WriteLine(@"
        >>> Trapped water problem >>>

        Insert the list of heights separated by comma
        ");
        var listOfHeights = Console.ReadLine().Split(",").ToList().Select(int.Parse).ToList();

        Console.WriteLine($"Altura: {getTrappedWater(listOfHeights)}");
    }
    private int getTrappedWater(List<int> heights)
    {
        int p1 = 0;
        int p2 = heights.Count-1;
        int trappedWater = 0;
        int maxLHeight = 0;
        int maxRHeight = 0;
        while (p1<p2)
        {
            if (heights[p1] < heights[p2])
            {
                if (heights[p1] < maxLHeight)
                {
                    trappedWater += maxLHeight - heights[p1];
                } else
                {
                    maxLHeight = heights[p1];
                }
                p1++;
            } else
            {
                if (heights[p2] < maxRHeight)
                {
                    trappedWater += maxRHeight - heights[p2];
                } else
                {
                    maxRHeight = heights[p2];
                }
                p2--;
            }
        }
        return trappedWater;
    }
}