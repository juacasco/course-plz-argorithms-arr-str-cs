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
            string evalWord1 = listOfWords[i];
            string evalWord2 = listOfWords[i+1];
            Console.WriteLine($"Evaluating: {evalWord1} and {evalWord2} ");
            for (int l = 0; l < Math.Min(evalWord1.Length, evalWord2.Length) ; l++)
            {
                Console.WriteLine($"Comparing letter {l}: {evalWord1[l]} -> {evalWord2[l]}");
                if ((int)alphabet[evalWord1[l]] > (int)alphabet[evalWord2[l]]) //TODO: add validation for missing letters or try..catch to handle it
                {
                    return false;
                }
            }
            if (evalWord1.Length > evalWord2.Length)
            {
                return false;
            }
        }
        return true;
    }
}
