using System.Text;

namespace HuffmanWords.Implementation;

public class Compressor
{
    private readonly FrequencyCalculator _frequencyCalculator;
    private readonly HuffmanTree _huffmanTree;

    public Compressor()
    {
        _frequencyCalculator = new FrequencyCalculator();
        _huffmanTree = new HuffmanTree();
    }

    public byte[] Compress(string input)
    {
        var frequencies = _frequencyCalculator.GetFrequencies(input).ToList();

        _huffmanTree.Build(frequencies);

        var blob = new Blob();

        var word = new StringBuilder();

        for (var i = 0; i < input.Length; i++)
        {
            var character = input[i];

            if (! char.IsLetter(character))
            {
                if (word.Length > 0)
                {
                    var wordAsString = word.ToString();

                    blob.Append(_huffmanTree.GetPath(wordAsString));

                    word.Clear();
                }

                var characterAsString = character.ToString();

                blob.Append(_huffmanTree.GetPath(characterAsString));

                continue;
            }

            word.Append(input[i]);
        }

        var data = new CompressedData
                   {
                       Data = blob.ToByteArray(),
                       Frequencies = frequencies,
                       OriginalLength = input.Length
                   };

        return data.Save();
    }
}