using HuffmanWords.Implementation;
using HuffmanWords.Models;
using Xunit;

namespace HuffmanWords.Tests.Implementation;

public class HuffmanTreeTests
{
    // This is a test. It is a random sentence.

    [Fact]
    public void Build_creates_expected_tree()
    {
        var frequencies = new List<WordFrequency>
                          {
                              new() { Frequency = 1, Word = "This" },
                              new() { Frequency = 8, Word = " " },
                              new() { Frequency = 2, Word = "is" },
                              new() { Frequency = 2, Word = "a" },
                              new() { Frequency = 1, Word = "test" },
                              new() { Frequency = 2, Word = "." },
                              new() { Frequency = 1, Word = "It" },
                              new() { Frequency = 1, Word = "random" },
                              new() { Frequency = 1, Word = "sentence" }
                          };

        var tree = new HuffmanTree();

        tree.Build(frequencies);

        var root = tree.Root;

        // TODO: Assertions!
    }
}