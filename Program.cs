using System.Runtime.ExceptionServices;
{
    string result = "";
    string userInput = Console.ReadLine();

    while (string.IsNullOrWhiteSpace(userInput) != true)
    {
        result += userInput;
        userInput = Console.ReadLine();
    }
    Console.WriteLine(result);
}

{
    string userInput2 = Console.ReadLine();
    int i = 0;
    while (string.IsNullOrWhiteSpace (userInput2) != true)
    {
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(userInput2);
            i++;
        }
        
    }
}
