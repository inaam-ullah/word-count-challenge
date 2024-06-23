using System.Text.RegularExpressions;

public class WordCounter
{
    public static Dictionary<string, int> CountWords(string paragraph)
    {
        string cleanedParagraph = Regex.Replace(paragraph.ToLower(), @"[^a-z\s]", "");
        string[] words = cleanedParagraph.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        return wordCounts;
    }
}
