using NUnit.Framework;

[TestFixture]
public class WordCounterTests
{
    [Test]
    public void TestWordCounter()
    {
        string paragraph1 = "Hello, hello! How are you? Are you doing well? Well, well, well.";
        Dictionary<string, int> expected1 = new Dictionary<string, int>
        {
            { "hello", 2 },
            { "how", 1 },
            { "are", 2 },
            { "you", 2 },
            { "doing", 1 },
            { "well", 4 }
        };
        Assert.AreEqual(expected1, WordCounter.CountWords(paragraph1));

        string paragraph2 = "Test test TEST. This is a test.";
        Dictionary<string, int> expected2 = new Dictionary<string, int>
        {
            { "test", 4 },
            { "this", 1 },
            { "is", 1 },
            { "a", 1 }
        };
        Assert.AreEqual(expected2, WordCounter.CountWords(paragraph2));

        string paragraph3 = "";
        Dictionary<string, int> expected3 = new Dictionary<string, int>();
        Assert.AreEqual(expected3, WordCounter.CountWords(paragraph3));
    }
}
