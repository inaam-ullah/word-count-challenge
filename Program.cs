string paragraph = "Hello, hello! How are you? Are you doing well? Well, well, well.";
Dictionary<string, int> result = WordCounter.CountWords(paragraph);

foreach (var item in result)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
