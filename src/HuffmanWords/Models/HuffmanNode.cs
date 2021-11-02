using HuffmanWords.Implementation;

namespace HuffmanWords.Models;

public class HuffmanNode
{
    [SecondarySort]
    public string Word { get; set; }

    [Priority]
    public int Frequency { get; set; }

    public HuffmanNode Left { get; set; }

    public HuffmanNode Right { get; set; }

    public HuffmanNode Parent { get; set; }
}