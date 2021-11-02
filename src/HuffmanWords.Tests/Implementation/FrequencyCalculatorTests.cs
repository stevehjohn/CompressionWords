using HuffmanWords.Implementation;
using Xunit;

namespace HuffmanWords.Tests.Implementation;

public class FrequencyCalculatorTests
{
    [Fact]
    public void GetFrequencies_returns_correct_word_frequencies()
    {
        const string testText =
            @" BOOK ONE
THE COMING OF THE MARTIANS

I.
THE EVE OF THE WAR.";

        var frequencies = new FrequencyCalculator().GetFrequencies(testText).ToList();

        Assert.Equal(1, frequencies.Single(f => f.Word == "BOOK").Frequency);
        Assert.Equal(10, frequencies.Single(f => f.Word == " ").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "ONE").Frequency);
        Assert.Equal(4, frequencies.Single(f => f.Word == "\r").Frequency);
        Assert.Equal(4, frequencies.Single(f => f.Word == "\n").Frequency);
        Assert.Equal(4, frequencies.Single(f => f.Word == "THE").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "COMING").Frequency);
        Assert.Equal(2, frequencies.Single(f => f.Word == "OF").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "MARTIANS").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "I").Frequency);
        Assert.Equal(2, frequencies.Single(f => f.Word == ".").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "EVE").Frequency);
        Assert.Equal(1, frequencies.Single(f => f.Word == "WAR").Frequency);

        Assert.Equal(13, frequencies.Count);
    }
}