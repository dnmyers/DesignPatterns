/// <summary>
/// Represents an abstract class for document parsers.
/// </summary>
public abstract class DocumentParser {
    /// <summary>
    /// Parses the given document.
    /// </summary>
    /// <param name="document">The document to be parsed.</param>
    public abstract void Parse(string document);
}

/// <summary>
/// Represents a parser for XML documents.
/// </summary>
public class XmlParser : DocumentParser {
    /// <summary>
    /// Parses the specified XML document.
    /// </summary>
    /// <param name="document">The XML document to parse.</param>
    public override void Parse(string document) {
        Console.WriteLine("Parsing XML document...");
        // XML parsing logic
    }
}

/// <summary>
/// Represents a JSON document parser.
/// </summary>
public class JsonParser : DocumentParser {
    /// <summary>
    /// Parses the given JSON document.
    /// </summary>
    /// <param name="document">The JSON document to parse.</param>
    public override void Parse(string document) {
        Console.WriteLine("Parsing JSON document...");
        // JSON parsing logic
    }
}

/// <summary>
/// Represents a parser for text documents.
/// </summary>
public class TextParser : DocumentParser {
    /// <summary>
    /// Parses the given text document.
    /// </summary>
    /// <param name="document">The text document to parse.</param>
    public override void Parse(string document) {
        Console.WriteLine("Parsing text document...");
        // Text parsing logic
    }
}

/// <summary>
/// Represents a parser for docx documents.
/// </summary>
public class DocXParser : DocumentParser {
    /// <summary>
    /// Parses the given docx document.
    /// </summary>
    /// <param name="document">The docx document to parse.</param>
    public override void Parse(string document) {
        Console.WriteLine("Parsing docx document...");
        // docx parsing logic
    }
}

/// <summary>
/// Factory class for creating document parsers based on the document type.
/// </summary>
public class DocumentParserFactory {
    /// <summary>
    /// Creates a document parser based on the specified document type.
    /// </summary>
    /// <param name="documentType">The type of the document.</param>
    /// <returns>A document parser instance.</returns>
    public DocumentParser CreateDocumentParser(string documentType) {
        switch (documentType) {
            case "Xml":
                return new XmlParser();
            case "Json":
                return new JsonParser();
            case "Text":
                return new TextParser();
            case "DocX":
                return new DocXParser();
            default:
                throw new ArgumentException("Invalid document type.");
        }
    }
}

/// <summary>
/// Represents the entry point of the program.
/// </summary>
public class Program {
    public static void Main(string[] args) {
        DocumentParserFactory factory = new DocumentParserFactory();

        DocumentParser xmlParser = factory.CreateDocumentParser("Xml");
        xmlParser.Parse("<xml>...</xml>");

        DocumentParser jsonParser = factory.CreateDocumentParser("Json");
        jsonParser.Parse("doc.json");
    }
}