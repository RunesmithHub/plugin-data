using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.DataLanguages.Languages;

/// <summary>JSON and JSON with Comments: their files, highlighting, comments and brackets.</summary>
public sealed class JsonLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Json { get; } = new("json", "JSON")
    {
        Extensions =
        [
            ".json", ".bowerrc", ".jscsrc", ".webmanifest", ".js.map", ".css.map", ".ts.map", ".har", ".jslintrc", ".jsonld", ".geojson",
            ".ipynb",
        ],
        FileNames = ["composer.lock", ".watchmanconfig"],
        ScopeName = "source.json",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']')],
        Icon = "file-json",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Jsonc { get; } = new("jsonc", "JSON with Comments")
    {
        Extensions = [".jsonc", ".eslintrc", ".eslintrc.json", ".jsfmtrc", ".jshintrc", ".swcrc", ".hintrc", ".babelrc"],
        FileNames =
        [
            "babel.config.json", ".babelrc.json", ".ember-cli", "tsconfig.json", "jsconfig.json", "global.json", "settings.json",
            ".markdownlint.json",
        ],
        ScopeName = "source.json.comments",
        LineComment = "//",
        BlockComment = ("/*", "*/"),
        Brackets = [('{', '}'), ('[', ']')],
        Icon = "file-json",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition JsonGrammar { get; } = GrammarFiles.Find("source.json", "json/JSON.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition JsoncGrammar { get; } = GrammarFiles.Find("source.json.comments", "json/JSONC.tmLanguage.json");
}
