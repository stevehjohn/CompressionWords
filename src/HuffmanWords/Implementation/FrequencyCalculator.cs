using System.Text;
using HuffmanWords.Models;

namespace HuffmanWords.Implementation;

public class FrequencyCalculator
{
    public IEnumerable<WordFrequency> GetFrequencies(string input)
    {
        var frequencies = new Dictionary<string, int>();

        var word = new StringBuilder();

        for (var i = 0; i < input.Length; i++)
        {
            var character = input[i];

            if (! char.IsLetter(character))
            {
                if (word.Length > 0)
                {
                    var wordAsString = word.ToString();

                    if (frequencies.ContainsKey(wordAsString))
                    {
                        frequencies[wordAsString]++;
                    }
                    else
                    {
                        frequencies.Add(wordAsString, 1);
                    }

                    word.Clear();
                }

                var characterAsString = character.ToString();

                if (frequencies.ContainsKey(characterAsString))
                {
                    frequencies[characterAsString]++;
                }
                else
                {
                    frequencies.Add(characterAsString, 1);
                }

                continue;
            }

            word.Append(input[i]);

        }

        return frequencies.Select(f => new WordFrequency { Word = f.Key, Frequency = f.Value });
    }
}