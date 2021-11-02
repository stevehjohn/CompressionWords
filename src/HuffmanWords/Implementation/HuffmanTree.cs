using System.Text;
using HuffmanWords.Models;

namespace HuffmanWords.Implementation;

public class HuffmanTree
{
    public HuffmanNode Root { get; set; }
    private HuffmanNode[] _nodes;

    public void Build(IEnumerable<WordFrequency> input)
    {
        var queue = new PriorityQueue<HuffmanNode, int>();

        var frequencies = input.ToList();

        _nodes = new HuffmanNode[frequencies.Count];

        var count = 0;

        foreach (var item in frequencies)
        {
            var node = new HuffmanNode { Frequency = item.Frequency, Word = item.Word };

            queue.Add(node);

            _nodes[count] = node;

            count++;
        }

        while (queue.Length > 1)
        {
            var left = queue.PopMin();

            var right = queue.PopMin();

            var node = new HuffmanNode
                       {
                           Frequency = left.Frequency + right.Frequency,
                           Left = left,
                           Right = right
                       };

            left.Parent = node;
            right.Parent = node;

            queue.Add(node);
        }

        Root = queue.PopMin();
    }

    public string GetPath(string word)
    {
        var node = _nodes.FirstOrDefault(n => n.Word == word);

        if (node == null)
        {
            return null;
        }

        var pathToRoot = new List<HuffmanNode>();

        while (node != null)
        {
            pathToRoot.Add(node);

            node = node.Parent;
        }

        var path = new StringBuilder();

        for (var i = pathToRoot.Count - 1; i > 0; i--)
        {
            path.Append(ReferenceEquals(pathToRoot[i - 1], pathToRoot[i].Left) ? '0' : '1');
        }

        return path.ToString();
    }
}