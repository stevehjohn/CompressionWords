using System.Diagnostics.CodeAnalysis;
using HuffmanWords.Console.Options;

namespace HuffmanWords.Console.Handlers;

[ExcludeFromCodeCoverage]
public class CompressionHandler
{
    private readonly CompressionOptions _options;

    public CompressionHandler(CompressionOptions options)
    {
        _options = options;
    }

    public void Execute()
    {
    }
}