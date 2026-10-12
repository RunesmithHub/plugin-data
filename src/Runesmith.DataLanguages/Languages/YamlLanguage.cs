using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.DataLanguages.Languages;

/// <summary>YAML: its files, highlighting, comments and brackets.</summary>
public sealed class YamlLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Yaml { get; } = new("yaml", "YAML")
    {
        Extensions = [".yml", ".eyaml", ".eyml", ".yaml"],
        ScopeName = "source.yaml",
        LineComment = "#",
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "settings",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SourceYamlGrammar { get; } = GrammarFiles.Find("source.yaml", "yaml/yaml.tmLanguage.json");
}
