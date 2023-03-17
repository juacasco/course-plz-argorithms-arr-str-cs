/*
    problem #1: Organize a list of words based on a different organized alphabet

*/

var repeat = true;
do
{
    Console.WriteLine(@"
Please select the option:
    1. > Run Alien Dictionary problem:
        It requires a list of words to be organized - parameter: List of words separated by comma. e.g. ""word,house,cat""
        Optionally, it could receive the alphabet to be used . parameter: list of characters. e.g. ""abcde""
    2. > Run Max Area:
        It receives a list of integers separated with comma and will calculate the area
    3. > exit
    ");
    var SelectedOption = Console.ReadLine();
    switch (SelectedOption)
    {
        case "1":
            Console.WriteLine("  >>> Running Alien Dictionary word sort");
            AlienDictionary alienDictionary = new AlienDictionary();
            alienDictionary.Execute();
            break;
        case "2":
            Console.WriteLine("  >>> Running Max Area");
            MaxArea mx = new MaxArea();
            mx.Execute();
            break;
        default:
            repeat = false;
            break;
    }
} while (repeat);

Console.WriteLine("Thanks for using this demo app -- press any letter to exit");
Console.ReadKey();






