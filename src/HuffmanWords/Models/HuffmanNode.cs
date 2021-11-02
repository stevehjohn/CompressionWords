namespace HuffmanWords.Models;

public class HuffmanNode
{
    public char Word { get; set; }

    public int Frequency { get; set; }

    public HuffmanNode Left { get; set; }

    public HuffmanNode Right { get; set; }

    public HuffmanNode Parent { get; set; }
}