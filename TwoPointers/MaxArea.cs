public class MaxArea
{
    public void Execute()
    {
        Console.Clear();
        Console.WriteLine(@"
        >>> Max area process >>>

        Insert the list of heights separated by comma
        ");
        var listOfHeights = Console.ReadLine().Split(",").ToList().Select(int.Parse).ToList();

        Console.WriteLine($"Altura: {getMaxArea(listOfHeights)}");

    }
    private int getMaxArea(List<int> heights)
    {
        int p1 = 0;
        int p2 = heights.Count-1;

        int maxArea = 0;

        while (p1<p2)
        {
            int area = int.Min(heights[p1],heights[p2]) * (p2-p1);
            maxArea = Math.Max(area,maxArea);
            if (heights[p1] > heights[p2])
            {
                p2--;
            }
            else
            {
                p1++;
            }
        }

        return maxArea;
    }
}