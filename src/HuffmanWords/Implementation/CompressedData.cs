using System.Text;
using HuffmanWords.Models;

namespace HuffmanWords.Implementation;

public class CompressedData
{
    public IEnumerable<WordFrequency> Frequencies { get; set; }

    public byte[] Data { get; set; }

    public int OriginalLength { get; set; }

    public byte[] Save()
    {
        using var stream = new MemoryStream();

        stream.Write(BitConverter.GetBytes(OriginalLength));

        stream.Write(BitConverter.GetBytes(Data.Length));

        stream.Write(Data);

        foreach (var frequency in Frequencies)
        {
            stream.Write(BitConverter.GetBytes(frequency.Frequency));

            stream.Write(Encoding.UTF8.GetBytes($"{frequency.Word}\0"));
        }

        return stream.ToArray();
    }
}
