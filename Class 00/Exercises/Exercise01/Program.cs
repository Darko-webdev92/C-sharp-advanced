Dictionary<string, int> dictionary = new Dictionary<string, int>();

string input;
while (true)
{
    Console.WriteLine("Enter name or press x to exit");
    input = Console.ReadLine().ToLower();

    if (input == "x")
    {
        break;
    }

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Invalid input");
        continue;
    }
    if (!dictionary.ContainsKey(input))
    {
        dictionary.Add(input, 1);
    }
}


Console.WriteLine("Enter text");
input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid text");
    return;
}

string[] words = input.Split(' ');

foreach (string word in words)
{
    if (dictionary.ContainsKey(word))
    {
        dictionary[word] += 1;
    }
}

foreach (KeyValuePair<string, int> item in dictionary)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
