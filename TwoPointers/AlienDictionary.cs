public class AlienDictionary
{
    public List<string> getOrderedList(List<string> unorderedList)
    {
        foreach (var item in unorderedList)
        {
            Console.WriteLine(item);
        }
        var newList = new List<string>();
        newList.Add("Just creating the initial function");
        return newList;
    }
    public void Execute()
    {
        Console.Clear();
        Console.WriteLine(@"
        >>> Alien dictionary process >>>

        Insert the list of words to be organized separated by comma
        ");
        var listOfWords = Console.ReadLine().Split(",").ToList();
        getOrderedList(listOfWords);
    }
}
