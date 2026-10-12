using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.DataLanguages.Languages;

/// <summary>INI and Properties: their files, highlighting, comments and brackets.</summary>
public sealed class IniLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Ini { get; } = new("ini", "INI")
    {
        Extensions = [".ini"],
        ScopeName = "source.ini",
        LineComment = ";",
        BlockComment = (";", " "),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "settings",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Properties { get; } = new("properties", "Properties")
    {
        Extensions = [".properties", ".cfg", ".conf", ".directory", ".gitattributes", ".gitconfig", ".gitmodules", ".editorconfig"],
        FileNames = ["gitconfig", ".env", ".editorconfig", ".gitattributes", ".gitconfig", ".gitmodules"],
        ScopeName = "source.ini",
        LineComment = "#",
        BlockComment = ("#", " "),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "settings",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition IniGrammar { get; } = GrammarFiles.Find("source.ini", "ini/ini.tmLanguage.json");
}
