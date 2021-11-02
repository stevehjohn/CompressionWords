namespace HuffmanWords.Implementation;

public class Compressor
{
    private readonly FrequencyCalculator _frequencyCalculator;

    public Compressor()
    {
        _frequencyCalculator = new FrequencyCalculator();
    }

    public byte[] Compress(string input)
    {
        var frequencies = _frequencyCalculator.GetFrequencies(input);

        throw new NotImplementedException();
    }
}