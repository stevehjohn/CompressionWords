using HuffmanWords.Models;

namespace HuffmanWords.Implementation;

public class CompressedData
{
    public IEnumerable<WordFrequency> Frequencies { get; set; }

    public byte[] Data { get; set; }

    public int OriginalLength { get; set; }

    public byte[] Save()
    {
        //var frequencies = Frequencies.ToList();

        //var frequencyTable = new byte[frequencies.Count * 8];

        //var count = 0;

        //foreach (var item in frequencies)
        //{
        //    Buffer.BlockCopy(BitConverter.GetBytes(item.Frequency), 0, frequencyTable, count * 8, 4);
        //    Buffer.BlockCopy(BitConverter.GetBytes((int) item.Character), 0, frequencyTable, count * 8 + 4, 4);

        //    count++;
        //}

        //var data = new byte[8 + frequencyTable.Length + Data.Length];

        //Buffer.BlockCopy(BitConverter.GetBytes(frequencies.Count), 0, data, 0, 4);
        //Buffer.BlockCopy(BitConverter.GetBytes(OriginalLength), 0, data, 4, 4);
        //Buffer.BlockCopy(frequencyTable, 0, data, 8, frequencyTable.Length);
        //Buffer.BlockCopy(Data, 0, data, 8 + frequencyTable.Length, Data.Length);

        //return data;

        throw new NotImplementedException();
    }
}
