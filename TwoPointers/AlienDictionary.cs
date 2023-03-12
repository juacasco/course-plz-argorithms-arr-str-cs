using System.Collections;
public class AlienDictionary
{
    private List<string> getOrderedList(List<string> unorderedList, string orderedAlphabet)
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

        Insert the list of words to be validated separated by comma
        ");
        var listOfWords = Console.ReadLine().Split(",").ToList();

        Console.WriteLine("Insert the alphabet to be used as ordered");

        var orderedAlphabet = Console.ReadLine();
        if (isAlienSorted(listOfWords, orderedAlphabet))
        {
            Console.WriteLine("TRUE -- It is ordered");
            return;
        } 
        Console.WriteLine("FALSE -- It is unordered");
    }

    private bool isAlienSorted(List<string> listOfWords, string orderedAlphabet)
    {
        //create hash table with the purpose of reducing algorithm complexity as hash table is O(1)
        Hashtable alphabet = new Hashtable();
        for (int i = 0; i < orderedAlphabet.Length; i++)
        {
            alphabet.Add(orderedAlphabet[i],i);
        }
        // loop on list of words to go one by one comparing first with second
        for (int i = 0; i < listOfWords.Count-1; i++)
        {
            int evalWord1Value = 0, evalWord2Value = 0;
            string evalWord1 = listOfWords[i];
            string evalWord2 = listOfWords[i+1];
            Console.WriteLine($"Evaluating: {evalWord1} and {evalWord2} ");
            for (int l = 0; l < evalWord1.Length; l++)
            {
                evalWord1Value += (int)alphabet[evalWord1[l]];
                evalWord2Value += (int)alphabet[evalWord2[l]];
                Console.WriteLine($"value1 {evalWord1Value} {evalWord1[l]} - value2 {evalWord2Value} {evalWord2[l]}");
            }
        }
        return false;
    }
}
