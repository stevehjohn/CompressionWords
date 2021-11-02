﻿using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using HuffmanWords.Console.Options;
using HuffmanWords.Implementation;
using HuffmanWords.Models;

namespace HuffmanWords.Console.Handlers;

[ExcludeFromCodeCoverage]
public class VisualisationHandler
{
    private readonly VisualiseOptions _options;
    private readonly HuffmanTree _tree;

    private string _visualisation;

    private const string NodeTemplate = "<li><a href='#'>{frequency}</a><ul>{left}{right}</ul></li>";

    private const string LeafTemplate = "<li><a href='#' class='leaf tooltip' data-text='{path}'>{frequency}<br/><span class='character'>{character}</span></a></li>";

    public VisualisationHandler(VisualiseOptions options)
    {
        _options = options;

        _tree = new HuffmanTree();
    }

    public void Execute()
    {
        var file = File.ReadAllText(_options.FileName);

        var frequencyCalculator = new FrequencyCalculator();

        var frequencies = frequencyCalculator.GetFrequencies(file);

        _tree.Build(frequencies);

        _visualisation = File.ReadAllText("Supporting Files\\Template.html");

        _visualisation = _visualisation.Replace("{document}", Path.GetFileNameWithoutExtension(_options.FileName));

        _visualisation = _visualisation.Replace("{css}", File.ReadAllText("Supporting Files\\Styles.css"));

        _visualisation = _visualisation.Replace("{nodes}", $"<ul>{ProcessNode(_tree.Root)}</ul>");

        var tempFile = Path.GetTempFileName().Replace(".tmp", ".html");

        File.WriteAllText(tempFile, _visualisation);

        Process.Start(new ProcessStartInfo
        {
            FileName = tempFile,
            UseShellExecute = true
        });

        if (!string.IsNullOrWhiteSpace(_options.OutputFileName))
        {
            File.WriteAllText(_options.OutputFileName, _visualisation);
        }
    }

    private string ProcessNode(HuffmanNode node)
    {
        var innerHtml = node.Word == null
                            ? NodeTemplate.Replace("{frequency}", node.Frequency.ToString())
                            : LeafTemplate.Replace("{frequency}", node.Frequency.ToString())
                                          .Replace("{character}", string.IsNullOrWhiteSpace(node.Word) ? "' '" : node.Word)
                                          .Replace("{path}", _tree.GetPath(node.Word));

        innerHtml = innerHtml.Replace("{left}", node.Left != null
            ? ProcessNode(node.Left)
            : string.Empty);

        innerHtml = innerHtml.Replace("{right}", node.Right != null
            ? ProcessNode(node.Right)
            : string.Empty);

        return innerHtml;
    }
}