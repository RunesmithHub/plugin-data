using System.Composition;
using Runesmith.Sdk.Languages;

namespace Runesmith.DataLanguages.Languages;

/// <summary>XML and XSL: their files, highlighting, comments and brackets.</summary>
public sealed class XmlLanguages
{
    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Xml { get; } = new("xml", "XML")
    {
        Extensions =
        [
            ".xml", ".xsd", ".ascx", ".atom", ".axml", ".axaml", ".bpmn", ".cpt", ".csl", ".csproj", ".csproj.user", ".dita", ".ditamap",
            ".dtd", ".ent", ".mod", ".dtml", ".fsproj", ".fxml", ".iml", ".isml", ".jmx", ".launch", ".menu", ".mxml", ".nuspec",
            ".opml", ".owl", ".proj", ".props", ".pt", ".publishsettings", ".pubxml", ".pubxml.user", ".rbxlx", ".rbxmx", ".rdf", ".rng",
            ".rss", ".shproj", ".storyboard", ".svg", ".targets", ".tld", ".tmx", ".vbproj", ".vbproj.user", ".vcxproj",
            ".vcxproj.filters", ".wsdl", ".wxi", ".wxl", ".wxs", ".xaml", ".xbl", ".xib", ".xlf", ".xliff", ".xpdl", ".xul", ".xoml",
            ".slnx", ".resx", ".config", ".manifest", ".runsettings", ".ruleset", ".editorconfig.xml",
        ],
        ScopeName = "text.xml",
        BlockComment = ("<!--", "-->"),
        Brackets = [('<', '>'), ('{', '}'), ('(', ')')],
        Icon = "code",
    };

    [Export(typeof(LanguageDefinition))]
    public LanguageDefinition Xsl { get; } = new("xsl", "XSL")
    {
        Extensions = [".xsl", ".xslt"],
        ScopeName = "text.xml.xsl",
        BlockComment = ("<!--", "-->"),
        Brackets = [('<', '>'), ('{', '}'), ('(', ')'), ('[', ']')],
        Icon = "file-code",
    };

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition XmlGrammar { get; } = GrammarFiles.Find("text.xml", "xml/xml.tmLanguage.json");

    [Export(typeof(GrammarDefinition))]
    public GrammarDefinition XslGrammar { get; } = GrammarFiles.Find("text.xml.xsl", "xml/xsl.tmLanguage.json");
}
