using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.DataLanguages.Languages;

/// <summary>SQL: its files, highlighting, comments and brackets.</summary>
public sealed class SqlLanguage
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Sql { get; } = new("sql", "SQL")
    {
        Extensions = [".sql", ".dsql"],
        ScopeName = "source.sql",
        LineComment = "--",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']'), ('(', ')')],
        Icon = "database",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition SqlGrammar { get; } = GrammarFiles.Find("source.sql", "sql/sql.tmLanguage.json");
}
