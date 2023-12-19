public abstract class DocumentParser {
    public abstract void Parse(string document);
}

public class XmlParser : DocumentParser {
    public override void Parse(string document) {
        Console.WriteLine("Parsing XML document...");
        // XML parsing logic
    }
}

public class JsonParser : DocumentParser {
    public override void Parse(string document) {
        Console.WriteLine("Parsing JSON document...");
        // JSON parsing logic
    }
}

public class TextParser : DocumentParser {
    public override void Parse(string document) {
        Console.WriteLine("Parsing text document...");
        // Text parsing logic
    }
}

public class DocXParser : DocumentParser {
    public override void Parse(string document) {
        Console.WriteLine("Parsing docx document...");
        // docx parsing logic
    }
}

public class DocumentParserFactory {
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

public class Program {
    public static void Main(string[] args) {
        DocumentParserFactory factory = new DocumentParserFactory();

        DocumentParser xmlParser = factory.CreateDocumentParser("Xml");
        xmlParser.Parse("<xml>...</xml>");

        DocumentParser jsonParser = factory.CreateDocumentParser("Json");
        jsonParser.Parse("doc.json");
    }
}