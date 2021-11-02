using CommandLine;
using HuffmanWords.Console.Handlers;
using HuffmanWords.Console.Options;

namespace HuffmanWords.Console.Infrastructure;

public class EntryPoint
{
    public static void Main(string[] arguments)
    {
        Parser.Default.ParseArguments<VisualiseOptions, CompressionOptions>(arguments)
              .WithParsed<VisualiseOptions>(o => new VisualisationHandler(o).Execute())
              .WithParsed<CompressionOptions>(o => new CompressionHandler(o).Execute());
    }
}